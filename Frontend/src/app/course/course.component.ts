import { DatePipe } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { forkJoin, map } from 'rxjs';
import { Course } from 'src/interfaces/Course';
import { Lesson } from 'src/interfaces/Lesson';
import { Progress } from 'src/interfaces/Progress';
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
  uncompletedLessonIds: number[] | undefined;
  isLoaded = false;
  progress: Progress | undefined;

  handler: any = null;

  constructor(
    private _lessonService: LessonService,
    private route: ActivatedRoute,
    private _courseService: CourseService,
    private _authService: AuthService,
    private router: Router,
    private datePipe: DatePipe
  ) {}

  ngOnInit() {
    this._authService.getLoggedInUser().subscribe((user) => {
      this.user = user;
      console.log(user?.username);
    });

    forkJoin([
      this._courseService.getCourseById(this.courseId!!),
      this._lessonService.getLessonsByCourseId(this.courseId!!),
      // this._authService.getLoggedInUser(),
      //TODO: Author Course and categories
      //TODO: UserTakesCourse
      this._courseService.checkTakesCourse(this.user?.id, this.courseId!!),
      // this._lessonService.getUserProgress(this.courseId!!, this.user?.id),
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
        // console.log(data);
        this.lessons = data.lessons;
        this.userTakesCourse = data.userTakesCourse;
        // this.takesCourse = data.userTakesCourse;
        // this.progress = data.userProgress.progress * 100;
        // this.uncompletedLessonIds = data.userProgress.uncompletedLessonIds;
        this.isLoaded = true;
      });

    this.getProgress();
    this.loadStripe();
  }

  pay(amount: any) {
    const all = this;
    var handler = (<any>window).StripeCheckout.configure({
      key: 'pk_test_51NH3AwHSO1paAufOEyyqanULYupuGrWU12P6ZzCwUTyBAhnxuezcrb4OiieQKSBeAgjGbcFa45Zsrz4CqxJ3MV1R00VigmemjD',
      locale: 'auto',
      token: function (token: any) {
        console.log(token);
        all.enrollCourse(all.courseId!);
      },
    });

    handler.open({
      name: all.course?.title,
      description: 'Enroll Course',
      amount: amount * 100,
    });
  }

  loadStripe() {
    if (!window.document.getElementById('stripe-script')) {
      var s = window.document.createElement('script');
      s.id = 'stripe-script';
      s.type = 'text/javascript';
      s.src = 'https://checkout.stripe.com/checkout.js';
      s.onload = () => {
        this.handler = (<any>window).StripeCheckout.configure({
          key: 'pk_test_51NH3AwHSO1paAufOEyyqanULYupuGrWU12P6ZzCwUTyBAhnxuezcrb4OiieQKSBeAgjGbcFa45Zsrz4CqxJ3MV1R00VigmemjD',
          locale: 'auto',
          token: function (token: any) {
            this.enrollCourse(this.courseId);
          },
        });
      };

      window.document.body.appendChild(s);
    }
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
  }

  getProgress() {
    this._lessonService
      .getUserProgress(this.courseId!!, this.user?.id)
      .subscribe(
        (progress) => {
          this.progress = progress;
          console.log(progress, this.lessons);
        },
        (error) => {
          if (error.status === 404) {
            console.log('Course not found.');
          }
        }
      );
  }

  reloadPage() {
    const currentUrl = this.router.url;
    console.log(this.progress);
    this.router
      .navigateByUrl('/blank', { skipLocationChange: true })
      .then(() => {
        this.router.navigate([currentUrl]);
      });
  }

  onStateChange(event: YT.OnStateChangeEvent, lessonId: string) {
    console.log(event);
    if (event.data === YT.PlayerState.ENDED) {
      // Video has finished playing; you can send your request or perform an action here
      console.log('Video has finished');
      // Call your function to send a request or perform some action
      this.onVideoFinished(lessonId);
    }
  }

  onVideoFinished(lessonId: string) {
    // Perform your action when the video finishes
    // You can send your request here
    this._lessonService
      .completeLesson(this.user!.id, this.courseId!, lessonId)
      .subscribe((response) => {
        this.reloadPage();

        console.log(response);
        // setTimeout(() => {
        //   this.reloadPage()
        // }, 1000);
      });
  }

  isLessonCompleted(lessonId: string): boolean {
    if (this.progress == null) {
      return false;
    }
    return this.progress?.completedLessons.includes(lessonId);
  }

  formatDate(dateString: string): string {
    const formattedDate = this.datePipe.transform(dateString, 'MMMM d, y');
    return formattedDate || 'Invalid Date'; // Handle invalid dates if needed
  }

  downloadCertificate() {
    this._courseService
      .downloadCertificate(this.user!.id, this.course!.id)
      .subscribe((data) => {
        console.log(data);
        const blob = new Blob([data], { type: 'application/pdf' });
        const fileName = 'Certificate.pdf';
        const url = window.URL.createObjectURL(blob);
        const a = document.createElement('a');
        a.href = url;
        a.download = fileName;
        a.click();
        window.URL.revokeObjectURL(url);
      });
  }
}
