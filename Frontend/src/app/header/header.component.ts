import { Component, Input } from '@angular/core';
import { User } from 'src/interfaces/User';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css'],
})
export class HeaderComponent {
  @Input()
  user: User | undefined;

  constructor() {
  }

  logout() {
    localStorage.removeItem('authToken');
    location.href = '/';
  }
}
