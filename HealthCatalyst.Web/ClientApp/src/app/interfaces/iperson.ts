import { IAddress } from './iaddress';
import { IAndriod } from './iandriod';
import { IInterest } from './iinterest';

export interface IPerson {
    givenName: string;
    surname: string;
    addresses: IAddress[];
    phones: IAndriod[];
    interests: IInterest[];
}
