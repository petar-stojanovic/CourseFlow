import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';
import { AllCoursesComponent } from './all-courses/all-courses.component';
import { CreateCourseComponent } from './create-course/create-course.component';
import { CourseComponent } from './course/course.component';
import { AllNonPublicCoursesComponent } from './all-non-public-courses/all-non-public-courses.component';

const routes: Routes = [
  { path: '', component: AllCoursesComponent },
  { path: 'course/all-non-public', component: AllNonPublicCoursesComponent },
  { path: 'course/create', component: CreateCourseComponent },
  { path: 'course/:id/lessons', component: CourseComponent },
  { path: 'login', component: LoginComponent },
  { path: 'register', component: RegisterComponent},
  { path: '**', redirectTo: '' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
