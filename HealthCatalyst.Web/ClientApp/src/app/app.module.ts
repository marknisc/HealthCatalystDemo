import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SearchbarComponent } from './components/searchbar/searchbar.component';
import { SearchResultsComponent } from './components/searchresults/searchresults.component';
import { InterfacesModule } from './interfaces/interfaces.module';
import { ServicesModule } from './services/services.module';

@NgModule({
  declarations: [
    AppComponent,
    SearchbarComponent,
    SearchResultsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    InterfacesModule ,
    ServicesModule.forRoot()   
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
