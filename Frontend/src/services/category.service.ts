import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Category } from 'src/interfaces/Category';

@Injectable({
  providedIn: 'root'
})
export class CategoryService {

  private readonly url = 'api/Category';

  constructor(private _http: HttpClient) {}

  getAllCategories(): Observable<Category[]> {
    return this._http.get<Category[]>(`${this.url}`, );
  }

}
