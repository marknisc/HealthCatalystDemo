import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
  ],
  exports: []
})
export class InterfacesModule { }

export * from './iperson'
export * from './iaddress'
export * from './iandriod';
export * from './iinterest';
