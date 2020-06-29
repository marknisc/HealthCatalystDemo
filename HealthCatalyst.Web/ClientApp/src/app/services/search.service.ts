import { Injectable } from '@angular/core';
import { Person } from '../interfaces/interfaces.module';

@Injectable({
  providedIn: 'root'
})
export class SearchService {

  constructor() { }

  search(searchTerm: string){
    return [
      {"givenName": "Bob", "surname": "Barker"}
    ];
  }
}
