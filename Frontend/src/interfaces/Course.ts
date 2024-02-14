import { Lesson } from './Lesson';
import { User } from './User';

export interface Course {
  id: string;
  title: string;
  description: string;
  thumbnail: string;
  price: number;
  categories: string[];
  dateCreated: string;
  isPublic: boolean;
  author: string;
  lessons: Lesson[];
  courseCategories?: CourseCategories[]
}


export interface CourseCategories{
  name: string;
}