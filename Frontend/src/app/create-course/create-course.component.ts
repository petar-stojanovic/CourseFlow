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
      title: ['Best C# Tutorials', Validators.required],
      description: [
        'Learn C# using the best tutorials available on YouTuvbe',
        Validators.required,
      ],
      thumbnail: [
        'https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTxl_1NJZktx1B6lBUhR4RyKZBavjUdYYEdYg&usqp=CAU',
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
      title: ['C# Tutorial - Full Course for Beginners', Validators.required],
      description: [
        "This course will give you a full introduction into all of the core concepts in C# (aka C Sharp). Follow along with the course and you'll be a C# programmer in no time!",
        Validators.required,
      ],
      url: [
        'https://www.youtube.com/watch?v=GhQdlIFylQ8',
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
