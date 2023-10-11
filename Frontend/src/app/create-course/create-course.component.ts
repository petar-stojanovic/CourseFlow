import { Component, OnInit } from '@angular/core';
import {
  FormArray,
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { Category } from 'src/interfaces/Category';
import { Course } from 'src/interfaces/Course';
import { Lesson } from 'src/interfaces/Lesson';
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
    });
  }

  fetchCategories() {
    this._categoryService.getAllCategories().subscribe((res) => {
      this.categoryList = res;
    });
  }

  ngOnInit(): void {
    this._authService.getLoggedInUser().subscribe((user) => {
      if (user == null) {
        this.router.navigateByUrl('login');
      } else {
        this.user = user;
      }
    });
  }

  addLesson() {
    const lessonGroup = this.fb.group({
      description: ['Lesson Description'],
      url: [
        'https://www.youtube.com/watch?v=dQw4w9WgXcQ',
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
      console.log(res);
    });
  }
}
