import { Injectable, Output, EventEmitter } from '@angular/core';
import { IPerson, PhoneType } from '../interfaces/interfaces.module';
import { Observable, ReplaySubject, Subject, pipe, of } from 'rxjs';
import { tap, catchError } from 'rxjs/operators'
import { HttpClient } from '@angular/common/http';
import { ConfigService } from './config.service';
import { IAppConfig } from '../interfaces/config';
import { Person } from '../models/person';
import { Address } from '../models/address';
import { Phone } from '../models/Phone';

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
    let url = this.settings.api.baseUrl + "search";

    // this.http.get<IPerson[]>(url)
    // .pipe(
    //   tap(result => { this.personsSubject.next(result) }),
    //   catchError(err => { console.log(err); return of([]); })
    // );    

    this.personsSubject.next([this.createDummyData()]);

    this.isSearching.emit(false); 
  }

  searchResults() : Observable<IPerson[]>{
    return this.personsSubject.asObservable();
  }

  private createDummyData() : Person{
    let a = new Address();
    a.Line1 = "Main St";
    a.City = "Anytown";
    a.State = "OH";
    a.PostalCode = "12345-5678";
    
    let ph = new Phone();
    ph.Number = 1234567890;
    ph.PhoneType = PhoneType.Mobile;

    let p = new Person();
    p.surname = "Bob";
    p.givenName = "Barker";
    p.addresses = [a];
    p.phones = [ph];

    return p;
  }
}
