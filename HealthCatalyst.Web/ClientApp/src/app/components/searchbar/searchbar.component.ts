import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-searchbar',
  templateUrl: './searchbar.component.html',
  styleUrls: ['./searchbar.component.sass']
})
export class SearchbarComponent implements OnInit {

  term: string;
  constructor() { }

  ngOnInit(): void {
  }

  onSearch(){
    
  }
}
