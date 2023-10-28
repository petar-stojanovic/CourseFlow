import { Component, OnInit } from '@angular/core';
import { Category } from 'src/interfaces/Category';
import { CategoryService } from 'src/services/category.service';

@Component({
  selector: 'app-categories',
  templateUrl: './categories.component.html',
  styleUrls: ['./categories.component.css']
})
export class CategoriesComponent implements OnInit {
  categories: Category[] = [];
  isLoaded = false;

  constructor(private categoryService: CategoryService) {}

  ngOnInit(): void {
    this.loadCategories();
  }

  loadCategories(): void {
    this.categoryService.getAllCategories().subscribe((result) => {
      this.categories = result;
      this.isLoaded = true;
    });
  }
}