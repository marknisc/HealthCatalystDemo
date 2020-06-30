import { BrowserModule } from '@angular/platform-browser';
import { NgModule, APP_INITIALIZER } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SearchbarComponent } from './components/searchbar/searchbar.component';
import { SearchResultsComponent } from './components/searchresults/searchresults.component';
import { InterfacesModule } from './interfaces/interfaces.module';
import { ServicesModule } from './services/services.module';
import { ConfigService } from '../app/services/config.service';

export function initializeApp(appConfig : ConfigService){
  return () => appConfig.load();
}

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
    HttpClientModule,
    InterfacesModule ,
    ServicesModule.forRoot()   
  ],
  providers: [
    ConfigService, {
      provide: APP_INITIALIZER,
      useFactory: initializeApp,
      deps: [ConfigService],
      multi: true
    }], 
  bootstrap: [AppComponent]
})
export class AppModule { }
