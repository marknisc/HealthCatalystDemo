import { NgModule, ModuleWithProviders } from '@angular/core';
import { CommonModule } from '@angular/common';
import{ SearchService } from './search.service';


@NgModule({
  declarations: [    
  ],
  imports: [
    CommonModule
  ],
  exports:[]
})
export class ServicesModule { 
  static forRoot() : ModuleWithProviders<ServicesModule>{
    return { 
      ngModule: ServicesModule,
      providers: [SearchService]
    }
  }
}
