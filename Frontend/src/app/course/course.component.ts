import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { forkJoin, map } from 'rxjs';
import { Course } from 'src/interfaces/Course';
import { Lesson } from 'src/interfaces/Lesson';
import { User } from 'src/interfaces/User';
import { AuthService } from 'src/services/auth.service';
import { CourseService } from 'src/services/course.service';
import { LessonService } from 'src/services/lesson.service';

@Component({
  selector: 'app-course',
  templateUrl: './course.component.html',
  styleUrls: ['./course.component.css'],
})
export class CourseComponent implements OnInit {
  course: Course | undefined;
  lessons: Lesson[] = [];
  user: User | null = null;
  userTakesCourse = false;
  courseId = this.route.snapshot.paramMap.get('id');
  progress: number | undefined;
  uncompletedLessonIds: number[] | undefined;
  isLoaded = false;

  constructor(
    private _lessonService: LessonService,
    private route: ActivatedRoute,
    private _courseService: CourseService,
    private _authService: AuthService,
    private router: Router
  ) {}

  ngOnInit() {
    this._authService.getLoggedInUser().subscribe(user =>{
      this.user = user
    }),

    forkJoin([
      this._courseService.getCourseById(this.courseId!!),
      this._lessonService.getLessonsByCourseId(this.courseId!!),
      // this._authService.getLoggedInUser(),
      //TODO: Author Course and categories
      //TODO: UserTakesCourse
      this._courseService.checkTakesCourse(this.user?.id, this.courseId!!),
      // this.courseService.getProgress(this.courseId, this.user?.id),
    ])
      .pipe(
        map(([course, lessons, userTakesCourse]) => {
          return { course, lessons, userTakesCourse };
        })
      )
      .subscribe((data) => {
        console.log(data);
        this.course = data.course;
        this.lessons = data.lessons;
        this.userTakesCourse = data.userTakesCourse;
        // this.takesCourse = data.userTakesCourse;
        // this.progress = data.userProgress.progress * 100;
        // this.uncompletedLessonIds = data.userProgress.uncompletedLessonIds;
        this.isLoaded = true;
      });
  }

  enrollCourse(courseId: string) {
    if (!this.user) {
      this.router.navigateByUrl('login');
    } else {
      this._courseService
        .enrollUserToCourse(this.user.id, courseId)
        .subscribe((res) => {
          this.reloadPage();
        });
    }
    // this.courseService.enrollUserToCourse(courseId);
  }

  reloadPage() {
    const currentUrl = this.router.url;
    this.router
      .navigateByUrl('/blank', { skipLocationChange: true })
      .then(() => {
        this.router.navigate([currentUrl]);
      });
  }

  onStateChange(event: YT.OnStateChangeEvent) {
    console.log(event);
    if (event.data === YT.PlayerState.ENDED) {
      // Video has finished playing; you can send your request or perform an action here
      console.log('Video has finished');
      // Call your function to send a request or perform some action
      this.onVideoFinished();
    }
  }

  onVideoFinished() {
    // Perform your action when the video finishes
    // You can send your request here
  }

  // downloadCertificate() {
  //   this.lessonService
  //     .downloadCertificate(this.courseId, this.user?.id)
  //     .subscribe((res) => {
  //       const fileURL = URL.createObjectURL(res);
  //       window.open(fileURL, '_blank');
  //     });
  // }
}
