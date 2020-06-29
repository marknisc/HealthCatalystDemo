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

export * from './person'
export * from './address'
export * from './andriod';
export * from './interest';
