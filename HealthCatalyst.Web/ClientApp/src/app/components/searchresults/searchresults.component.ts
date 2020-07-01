import { Component, OnInit, Input } from '@angular/core';
import { SearchService } from '../../services/search.service';
import { Person } from '../../models/person';

@Component({
  selector: 'app-searchresults',
  templateUrl: './searchresults.component.html',
  styleUrls: ['./searchresults.component.sass']
})
export class SearchResultsComponent implements OnInit {

  @Input() searchTerm: string;
  searchResults: Person[];
  isLoading: boolean = false;
  results: boolean = false;
  noResults: boolean = false;

  constructor(private searchSvc: SearchService) { 
  }

  ngOnInit(): void {
    this.searchSvc.searchResults().subscribe(
      p => {
      this.searchResults = p;
      this.noResults = false;// (this.searchResults.length == 0);
      this.results = false; //(this.searchResults.length != 0);;
    },
    e => console.log(e)
    );

    this.searchSvc.isSearching.subscribe(p => {
      this.isLoading = p;
    });
  }

}
