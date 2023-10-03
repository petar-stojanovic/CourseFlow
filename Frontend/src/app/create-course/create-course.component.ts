import { Component, OnInit } from '@angular/core';
import {
  FormBuilder,
  FormControl,
  FormGroup,
  Validators,
} from '@angular/forms';
import { MatChipInputEvent } from '@angular/material/chips';
import { ActivatedRoute, Router } from '@angular/router';
import { Category } from 'src/interfaces/Category';
import { CategoryService } from 'src/services/category.service';

@Component({
  selector: 'app-create-course',
  templateUrl: './create-course.component.html',
  styleUrls: ['./create-course.component.css'],
})
export class CreateCourseComponent implements OnInit {
  isLoaded = false;
  courseForm: FormGroup | null = null;
  categoryList: Category[] | null = null;

  constructor(
    private fb: FormBuilder,
    private _categoryService: CategoryService
  ) {
    this.fetchCategories();
    this.createForm();
    this.isLoaded = true;
  }

  createForm() {
    this.courseForm = this.fb.group({
      title: ['', Validators.required],
      description: ['', Validators.required],
      thumbnail: ['', Validators.required],
      price: [0, Validators.min(0)],
      categories: [[], Validators.required],
      // lessons: [[], Validators.required],
      lessons: [[]],
    });
  }

  fetchCategories() {
    this._categoryService.getAllCategories().subscribe((res) => {
      this.categoryList = res;
      console.log(this.categoryList);
    });
  }

  ngOnInit(): void {}

  onSubmit() {
    const formData = this.courseForm!!.value;
    console.log(formData); // You can send this data to your backend or perform any other actions.
  }

  addLesson(): void {}
}
