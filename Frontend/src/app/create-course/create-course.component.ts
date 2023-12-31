import { Component, OnInit } from '@angular/core';
import {
  AbstractControl,
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  ValidationErrors,
  ValidatorFn,
  Validators,
} from '@angular/forms';
import { Router } from '@angular/router';
import { Category } from 'src/interfaces/Category';
import { Course } from 'src/interfaces/Course';
import { User } from 'src/interfaces/User';
import { AuthService } from 'src/services/auth.service';
import { CategoryService } from 'src/services/category.service';
import { CourseService } from 'src/services/course.service';

@Component({
  selector: 'app-create-course',
  templateUrl: './create-course.component.html',
  styleUrls: ['./create-course.component.css'],
})
export class CreateCourseComponent implements OnInit {
  isLoaded = false;
  user: User | null = null;
  courseForm: FormGroup | null = null;
  categoryList: Category[] | null = null;
  isFileMethod: boolean = false;
  isFileUploaded: boolean = false;

  constructor(
    private fb: FormBuilder,
    private _categoryService: CategoryService,
    private _courseService: CourseService,
    private _authService: AuthService,
    private router: Router
  ) {
    this.fetchCategories();
    this.createForm();
    this.isLoaded = true;
  }

  ngOnInit(): void {
    this._authService.getLoggedInUser().subscribe((user) => {
      if (user == null) {
        this.router.navigateByUrl('login');
      } else {
        this.user = user;
      }
    });

    this.courseForm!.get('isFileMethod')?.valueChanges.subscribe(
      (isFileMethod: boolean) => {
        if (isFileMethod) {
          this.courseForm?.removeControl('lessons');
        } else {
          this.courseForm?.addControl('lessons', this.fb.array([]));
          this.addLesson();
        }
        this.courseForm?.updateValueAndValidity();
      }
    );
  }

  onSlideToggleChange(event: any) {
    this.isFileMethod = !this.isFileMethod;
  }

  createForm() {
    this.courseForm = this.fb.group({
      title: ['Course Title', Validators.required],
      description: ['Course Description', Validators.required],
      thumbnail: [
        'https://img-c.udemycdn.com/course/750x422/473160_d929_3.jpg',
        Validators.required,
      ],
      price: [10, Validators.required],
      categories: [[], Validators.required],
      lessons: this.fb.array([]),
      isFileMethod: [false],
      isFileUploaded: [false],
    });

    this.addLesson();
  }

  fetchCategories() {
    this._categoryService.getAllCategories().subscribe((res) => {
      this.categoryList = res;
    });
  }

  addLesson() {
    const lessonGroup = this.fb.group({
      description: ['', Validators.required],
      url: [
        '',
        [
          Validators.required,
          Validators.pattern(
            /^(http(s)?:\/\/)www\.((youtube\.com\/)|(youtu.be\/))[\S]+$/
          ),
        ],
      ],
    });
    this.lessons.push(lessonGroup);
  }

  removeLesson(index: number) {
    this.lessons.removeAt(index);
  }

  get lessons() {
    return this.courseForm!!.get('lessons') as FormArray;
  }

  onSubmit() {
    const formData = this.courseForm!!.value;
    formData.author = this.user;
    this._courseService.createCourse(formData as Course).subscribe((res) => {
      this.router.navigate(['/']);
      console.log(res);
    });
  }

  onFileChange(event: any) {
    const file = event.target.files[0];
    if (file) {
      const formData = new FormData();
      formData.append('file', file);
      this.courseForm?.get('isFileUploaded')?.setValue(true);
      setTimeout(() => {
        // this.router.navigate(['/']);
        this.isFileUploaded = true;
      }, 1000);
      this.courseForm?.updateValueAndValidity();
      this._courseService.createLessonsFromFile(formData).subscribe();
    }
  }
}
