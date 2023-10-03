import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { User } from 'src/interfaces/User';
import { UserLogin } from 'src/interfaces/UserLogin';
import { UserRegister } from 'src/interfaces/UserRegister';

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
    return this._http.post<User>(`${this.url}/${token}`, {});
  }

  public getUserWithId(id: string): Observable<User> {
    return this._http.post<User>(`${this.url}/user/${id}`, {});
  }
}
