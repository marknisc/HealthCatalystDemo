import { IPerson } from '../interfaces/iperson';
import { Address } from './address';
import { Phone } from './Phone';
import { Interest } from './interest';

export class Person implements IPerson {
    constructor(personId: number,givenName: string, surname: string, addresses: Address[], phones: Phone[], interests: Interest[]){
      this.personId = personId;
      this.givenName = givenName;
      this.surname = surname;
      this.addresses = addresses;
      this.phones = phones;
      this.interests = interests;
    }
    personId: number;
    givenName: string;
    surname: string;
    photo: any;
    addresses: Address[];
    phones: Phone[];
    interests: Interest[];

  toString(): string {
    return `${this.givenName} ${this.surname}`;
  }
}
