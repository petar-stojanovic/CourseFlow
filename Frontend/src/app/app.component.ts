import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, OnDestroy, OnInit } from '@angular/core';
import { User } from 'src/interfaces/User';
import { AuthService } from 'src/services/auth.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css'],
})
export class AppComponent implements OnInit {
  isUserLoggedIn = false;
  user: User | undefined;
  mobileQuery: MediaQueryList;
  _mobileQueryListener: () => void;

  constructor(
    changeDetectorRef: ChangeDetectorRef,
    media: MediaMatcher,
    private _authService: AuthService
  ) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }

  ngOnInit(): void {
    const token = localStorage.getItem('authToken');
    if (token) {
      this.isUserLoggedIn = true;
      this._authService.getUserWithToken(token).subscribe((result) => {
        this.user = result;
        console.log('OMG', this.user);
      });
    }
  }


}
