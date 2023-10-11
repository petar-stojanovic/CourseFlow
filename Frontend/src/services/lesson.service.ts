import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Lesson } from 'src/interfaces/Lesson';

@Injectable({
  providedIn: 'root',
})
export class LessonService {
  private readonly url = 'api/Lesson';

  constructor(private _http: HttpClient) {}

  getLessonsByCourseId(courseId: string): Observable<Lesson[]> {
    return this._http.get<Lesson[]>(`${this.url}/${courseId}`);
  }
}
