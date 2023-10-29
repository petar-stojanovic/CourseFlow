import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Lesson } from 'src/interfaces/Lesson';
import { Progress } from 'src/interfaces/Progress';

@Injectable({
  providedIn: 'root',
})
export class LessonService {
  private readonly url = 'api/Lesson';

  constructor(private _http: HttpClient) {}

  getLessonsByCourseId(courseId: string): Observable<Lesson[]> {
    return this._http.get<Lesson[]>(`${this.url}/${courseId}`);
  }

  completeLesson(
    userId: string,
    courseId: string,
    lessonId: string
  ): Observable<any> {
    const url = `${this.url}/completeLesson`;

    const data = {
      userId: userId.toString(), // Ensure you convert the GUID to a string
      courseId: courseId.toString(),
      lessonId: lessonId.toString(),
    };
    console.log(data)
    return this._http.post<any>(url, data);
  }

  getUserProgress(courseId: string, userId?: string): Observable<Progress> {
    const url = `${this.url}/userProgress?userId=${userId}&courseId=${courseId}`;
    return this._http.get<Progress>(url);
  }
}
