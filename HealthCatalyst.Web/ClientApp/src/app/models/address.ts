import {IAddress} from '../interfaces/iaddress'

export class Address implements IAddress{
    AddressId: number;
    PersonId: number;
    Line1: string;
    Line2: string;
    City: string;
    State: string;
    PostalCode: string;

  toString(): string {
    return `${this.Line1}<br/>${this.City} ${this.State} ${this.PostalCode}`;
  }
}
