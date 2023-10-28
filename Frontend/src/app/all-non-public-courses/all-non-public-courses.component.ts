import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, OnInit } from '@angular/core';
import { FormControl } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { ActivatedRoute, Router } from '@angular/router';
import { debounceTime, distinctUntilChanged } from 'rxjs';
import { Course } from 'src/interfaces/Course';
import { CourseService } from 'src/services/course.service';
import { DialogConfirmationComponent } from '../dialog-confirmation/dialog-confirmation.component';

@Component({
  selector: 'app-all-non-public-courses',
  templateUrl: './all-non-public-courses.component.html',
  styleUrls: ['./all-non-public-courses.component.css'],
})
export class AllNonPublicCoursesComponent implements OnInit {
  isLoaded = false;
  courseList: Course[] = [];

  constructor(
    private router: Router,
    private dialog: MatDialog,
    private _courseService: CourseService
  ) {}

  ngOnInit(): void {
    this.getAllNonPublishedCourses();
  }

  getAllNonPublishedCourses() {
    this._courseService.getAllPrivateCourses().subscribe((result) => {
      this.courseList = result;
      this.isLoaded = true;
    });
  }

  openConfirmationDialog(id: string): void {
    this.dialog
      .open(DialogConfirmationComponent, {
        data: id,
      })
      .afterClosed()
      .subscribe((confirmed: Boolean) => {
        if (confirmed) {
          this._courseService
            .makeCoursePublic(id)
            .subscribe((x) => console.log(x));
            this.router.navigateByUrl('/RefreshComponent', { skipLocationChange: true }).then(() => {
              this.router.navigate(['/course/all-non-public']);
          });
        }
      });
  }
}
