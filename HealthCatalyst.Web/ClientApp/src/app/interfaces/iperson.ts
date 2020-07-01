import { IAddress } from './iaddress';
import { IAndriod } from './iandriod';
import { IInterest } from './iinterest';

export interface IPerson {
    personId: number;
    givenName: string;
    surname: string;
    photo: [];
    addresses: IAddress[];
    phones: IAndriod[];
    interests: IInterest[];

    photoToSrc(): string;
}
