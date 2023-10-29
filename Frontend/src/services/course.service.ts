import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Course } from 'src/interfaces/Course';


@Injectable({
  providedIn: 'root',
})
export class CourseService {
  private readonly url = 'api/Course';

  constructor(private _http: HttpClient) {}

  getAllCourses(): Observable<Course[]> {
    return this._http.get<Course[]>(`${this.url}`);
  }

  getAllPrivateCourses(): Observable<Course[]> {
    return this._http.get<Course[]>(`${this.url}/private`);
  }

  getAllPublicCourses(
    search?: string,
    categoryName?: string
  ): Observable<Course[]> {
    let queryParams = new HttpParams();
    if (search && categoryName) {
      queryParams = queryParams.append('search', search);
      queryParams = queryParams.append('categoryName', categoryName);
    } else if (search) {
      queryParams = queryParams.append('search', search);
    } else if (categoryName) {
      queryParams = queryParams.append('categoryName', categoryName);
    }

    return this._http.get<Course[]>(`${this.url}/public`, {
      params: queryParams,
    });
  }

  createCourse(data: Course): Observable<Course> {
    return this._http.post<Course>(`${this.url}/create`, data);
  }

  getCourseById(courseId: string): Observable<Course> {
    return this._http.get<Course>(`${this.url}/${courseId}`);
  }

  enrollUserToCourse(userId: string, courseId: string): Observable<any> {
    return this._http.post<any>(`${this.url}/enroll`, {
      userId: userId,
      courseId: courseId,
    });
  }

  checkTakesCourse(
    userId: string | undefined,
    courseId: string
  ): Observable<boolean> {
    console.log(userId, courseId);
    if (!userId) {
      return of(false);
    }
    return this._http.post<boolean>(`${this.url}/checkUserTakesCourse`, {
      userId: userId,
      courseId: courseId,
    });
  }

  createLessonsFromFile(file: any): Observable<any> {
    return this._http.post<any>(`${this.url}/createLessonsForCourse`, file);
  }

  makeCoursePublic(courseId: string): Observable<Course> {
    return this._http.get<Course>(`${this.url}/makeCoursePublic/${courseId}`);
  }

  downloadCertificate(userId: string, courseId: string): Observable<any> {
    const requestData = JSON.stringify({ userId, courseId });

    return this._http.post(`${this.url}/downloadCertificate`, requestData, {
      responseType: 'arraybuffer',
      headers: new HttpHeaders({ 'Content-Type': 'application/json' }),
    });
  }
}
