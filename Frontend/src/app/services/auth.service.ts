import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { User } from '../interfaces/User';
import { Observable } from 'rxjs';
import { UserRegister } from '../interfaces/UserRegister';
import { UserLogin } from '../interfaces/UserLogin';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private url = 'api/Auth';

  constructor(private _http: HttpClient) {}

  register(user: UserRegister): Observable<User> {
    return this._http.post<User>(`${this.url}/register`, user);
  }

  login(user: UserLogin): Observable<string> {
    return this._http.post(`${this.url}/login`, user, { responseType: 'text' });
  }

  public getUserWithToken(token: string): Observable<User> {
    return this._http.post<User>(`${this.host}/${token}`, {});
  }

  public getUserWithId(id: string): Observable<User> {
    return this._http.post<User>(`${this.host}/user/${id}`, {});
  }
}
