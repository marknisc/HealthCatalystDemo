import {IAddress} from '../interfaces/iaddress'

export class Address implements IAddress{
    constructor(addressId: number, personId: number, line1: string, line2 : string, city: string, state: string, postalCode : string){
      this.addressId = addressId;
      this.personId = personId;
      this.line1 = line1;
      this.line2 = line2;
      this.city = city;
      this.state = state;
      this.postalCode = postalCode;
    }

    addressId: number;
    personId: number;
    line1: string;
    line2: string;
    city: string;
    state: string;
    postalCode: string;

  toString(): string {
    return `${this.line1}<br/>${this.city} ${this.state} ${this.postalCode}`;
  }
}
