import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, of, tap } from 'rxjs';
import { User } from 'src/interfaces/User';
import { UserLogin } from 'src/interfaces/UserLogin';
import { UserRegister } from 'src/interfaces/UserRegister';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  private cachedUser: User | null;
  private url = 'api/Auth';

  constructor(private _http: HttpClient) {
    this.cachedUser = null;
  }

  register(user: UserRegister): Observable<User> {
    return this._http.post<User>(`${this.url}/register`, user);
  }

  login(user: UserLogin): Observable<string> {
    return this._http.post(`${this.url}/login`, user, { responseType: 'text' });
  }

  public getUserWithToken(token: string): Observable<User> {
    return this._http.post<User>(`${this.url}/${token}`, {}).pipe(
      tap((user) => {
        this.cachedUser = user;
        localStorage.setItem('user_data', JSON.stringify(user));
      })
    );
  }

  public getUserWithId(id: string): Observable<User> {
    return this._http.post<User>(`${this.url}/user/${id}`, {});
  }

  public setCachedUser(user: User): void {
    this.cachedUser = user;
  }

  public removeCachedUser(): void {
    this.cachedUser = null;
    localStorage.removeItem('user_data');
  }

  public getLoggedInUser(): Observable<User | null> {
    const userData = localStorage.getItem('user_data');
    if (userData) {
      this.cachedUser = JSON.parse(userData);
    }
    return of(this.cachedUser);
  }
}
