import { Injectable, Output, EventEmitter } from '@angular/core';
import { Person } from '../interfaces/interfaces.module';
import { Observable, ReplaySubject, Subject, pipe, of } from 'rxjs';
import { tap, catchError } from 'rxjs/operators'
import { HttpClient } from '@angular/common/http';
import { ConfigService } from './config.service';
import { IAppConfig } from '../interfaces/config';

@Injectable({
  providedIn: 'root'
})
export class SearchService {
  personsSubject: Subject<Person[]>;
  settings: IAppConfig;

  @Output() isSearching : EventEmitter<boolean> = new EventEmitter();

  constructor(private http: HttpClient) { 
    this.personsSubject = new ReplaySubject(1);
    this.settings = ConfigService.settings;
  }

  search(searchTerm: string){
    this.isSearching.emit(true);
    let url = this.settings.api.baseUrl + "search";

    this.http.get<Person[]>(url)
    .pipe(
      tap(result => { this.personsSubject.next(result) }),
      catchError(err => { console.log(err); return of([]); })
    );
    this.isSearching.emit(false); 
  }

  searchResults() : Observable<Person[]>{
    return this.personsSubject.asObservable();
  }
}
