import { Injectable, Output, EventEmitter } from '@angular/core';
import { IPerson, PhoneType } from '../interfaces/interfaces.module';
import { Observable, ReplaySubject, Subject, pipe, of } from 'rxjs';
import { tap, catchError, map } from 'rxjs/operators'
import { HttpClient } from '@angular/common/http';
import { ConfigService } from './config.service';
import { IAppConfig } from '../interfaces/config';
import { Person } from '../models/person';
import { Address } from '../models/address';
import { Phone } from '../models/Phone';
import { Interest } from '../models/interest';

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  personsSubject: Subject<IPerson[]>;
  settings: IAppConfig;

  @Output() isSearching : EventEmitter<boolean> = new EventEmitter();

  constructor(private http: HttpClient) { 
    this.personsSubject = new ReplaySubject(1);
    this.settings = ConfigService.settings;
  }

  search(searchTerm: string){
    this.isSearching.emit(true);
    let url = this.settings.api.baseUrl + `search?term=${searchTerm}`;

    console.log("URL: " + url);

    this.http.get<IPerson[]>(url)
    .subscribe(res => 
      { 
        let persons = new Array<Person>();

        res.forEach(p => {
          var person = new Person(p.personId, p.givenName, p.surname, new Array<Address>(), new Array<Phone>(), new Array<Interest>());

          p.addresses.forEach(a => {
            person.addresses.push(new Address(a.addressId, a.personId, a.line1, a.line2, a.city, a.state, a.postalCode))
          });

          p.phones.forEach(p =>{ 
            person.phones.push(new Phone(p.phoneId, p.personId, p.number, p.type));
          });

          p.interests.forEach(i => {
            person.interests.push(new Interest(i.interestId, i.personId, i.description));
          });
          persons.push(person);
        });
        this.personsSubject.next(persons);
      });

    this.isSearching.emit(false); 
  }

  searchResults() : Observable<Person[]>{
    return this.personsSubject.asObservable();
  }
}
