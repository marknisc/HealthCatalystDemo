import { Component, OnInit } from '@angular/core';
import { SearchService } from 'src/app/services/search.service';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.sass']
})
export class SearchbarComponent implements OnInit {

  term: string;
  constructor(private searchSvc: SearchService) { }

  ngOnInit(): void {
  }

  onSearch(){
    this.searchSvc.search(this.term);
  }
}
