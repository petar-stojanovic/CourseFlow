import { Lesson } from './Lesson';
import { User } from './User';

export interface Course {
  id: string;
  title: string;
  description: string;
  thumbnail: string;
  price: number;
  categories: string[];
  dateTime: string;
  isPublic: boolean;
  author: User;
  lessons: Lesson[];
}
