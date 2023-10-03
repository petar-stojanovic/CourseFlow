import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { UserLogin } from 'src/interfaces/UserLogin';
import { AuthService } from '../../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css'],
})
export class LoginComponent implements OnInit {
  loginForm: any;
  fieldRequired = 'This field is required';
  invalidCredentials = false;
  errorMessage = '';

  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit() {
    this.createForm();
  }

  createForm() {
    this.loginForm = new FormGroup({
      username: new FormControl(null, [Validators.required]),
      password: new FormControl(null, [Validators.required]),
    });
  }

  checkValidation(input: string) {
    const validation =
      this.loginForm.get(input).invalid &&
      (this.loginForm.get(input).dirty || this.loginForm.get(input).touched);
    return validation;
  }

  onSubmit(formData: FormGroup) {
    const username = formData.value.username;
    const password = formData.value.password;
    this.authService.login({ username, password } as UserLogin).subscribe({
      next: (token: string) => {
        console.log(token);
        localStorage.setItem('authToken', token);
        this.errorMessage = '';
        location.href = '/';
      },
      error: (message) => {
        this.errorMessage = message.error;
        console.log('Error logging in:', message.error);
      },
    });
  }
}
