import { IAndriod, PhoneType } from '../interfaces/iandriod'

export class Phone implements IAndriod {
    PhoneId: number;
    PersonId: number;
    Number: number;
  PhoneType: PhoneType;

  toString(): string {
    let numstr = this.Number.toString();
    return `${PhoneType[this.PhoneType]}: (${numstr.substring(0,3)})${numstr.substring(2,5)}-${numstr.substring(6)}`;
  }
}
