import { HttpClient, HttpHeaders, HttpParams } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { Course } from 'src/interfaces/Course';
import { ISession } from 'src/interfaces/ISession';
import { StripeCheckout } from 'src/interfaces/StripeCheckout';

declare const Stripe: any;

@Injectable({
  providedIn: 'root',
})
export class CourseService {
  private readonly url = 'api/Course';

  constructor(private _http: HttpClient) {}

  getMembership(): Observable<StripeCheckout> {
    return of({
      id: '1',
      priceId: 'Dont forget to add your price id ',
      name: 'Awesome Membership Plan',
      price: '$9.00',
      features: [
        'Up to 5 users',
        'Basic support on Github',
        'Monthly updates',
        'Free cancelation',
      ],
    });
  }


  requestMemberSession(priceId: string): void {
    this._http
      .post<ISession>(this.url + '/create-checkout-session', {
        priceId: priceId,
      })
      .subscribe((session) => {
        this.redirectToCheckout(session);
      });
  }

  redirectToCheckout(session: ISession) {
    const stripe = Stripe('pk_test_51NH3AwHSO1paAufOEyyqanULYupuGrWU12P6ZzCwUTyBAhnxuezcrb4OiieQKSBeAgjGbcFa45Zsrz4CqxJ3MV1R00VigmemjD');

    stripe.redirectToCheckout({
      sessionId: session.sessionId,
    });
  }

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
