import { Component, OnInit, Input } from '@angular/core';
import { SearchService } from '../../services/search.service';
import { Person } from '../../interfaces/interfaces.module';

@Component({
  selector: 'app-searchresults',
  templateUrl: './searchresults.component.html',
  styleUrls: ['./searchresults.component.sass']
})
export class SearchResultsComponent implements OnInit {

  @Input() searchTerm: string;
  searchResults: Person[];

  constructor(private searchSvc: SearchService) { }

  ngOnInit(): void {
    this.searchSvc.searchResults().subscribe(p => {
      this.searchResults = p;
    },
    e => console.log(e));
  }

}
