import { IPerson } from '../interfaces/iperson';
import { Address } from './address';
import { Phone } from './Phone';
import { Interest } from './interest';

export class Person implements IPerson {
    givenName: string;
    surname: string;
    addresses: Address[];
    phones: Phone[];
    interests: Interest[];

  toString(): string {
    return `${this.givenName} ${this.surname}`;
  }
}
