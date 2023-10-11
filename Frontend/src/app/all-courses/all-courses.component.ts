import { Component, OnInit, ChangeDetectorRef } from '@angular/core';
import { CourseService } from 'src/services/course.service';
import { MediaMatcher } from '@angular/cdk/layout';
import { FormControl } from '@angular/forms';
import { debounceTime, distinctUntilChanged } from 'rxjs';
import { ActivatedRoute, Router } from '@angular/router';
import { Course } from 'src/interfaces/Course';

@Component({
  selector: 'app-all-courses',
  templateUrl: './all-courses.component.html',
  styleUrls: ['./all-courses.component.css'],
})
export class AllCoursesComponent implements OnInit {
  mobileQuery: MediaQueryList;
  _mobileQueryListener: () => void;
  searchQuery = '';
  categoryQuery = '';
  isLoaded = false;
  courseList: Course[] = [];
  searchControl = new FormControl();

  constructor(
    private _courseService: CourseService,
    private router: Router,
    private route: ActivatedRoute,
    changeDetectorRef: ChangeDetectorRef,
    media: MediaMatcher
  ) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }


  ngOnInit(): void {
    this.route.queryParams.subscribe((params) => {
      this.searchQuery = params['search'] || null;
      this.categoryQuery = params['category'] || null;
      this.getPublicCourses(this.searchQuery, this.categoryQuery);
      this.searchControl.setValue(this.searchQuery);
    });

    this.searchControl.valueChanges
      .pipe(debounceTime(400), distinctUntilChanged())
      .subscribe((value) => {
        const category = this.route.snapshot.queryParams['category'];
        if (category) {
          this.router.navigate([''], {
            queryParams: { search: value, category: category },
          });
        } else {
          this.router.navigate(['/'], {
            queryParams: { search: value },
          });
        }
      });
  }

  getPublicCourses(search?: string, categoryName?: string) {
    this._courseService.getAllPublicCourses(search, categoryName).subscribe((result) => {
      this.courseList = result;
      this.isLoaded = true;
    });
  }
}
