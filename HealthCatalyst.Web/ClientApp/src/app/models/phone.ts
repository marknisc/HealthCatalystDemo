import { IAndriod, PhoneType } from '../interfaces/iandriod'

export class Phone implements IAndriod {
    constructor(phoneId: number, personId: number, number: number, type: PhoneType){
      this.phoneId = phoneId;
      this.personId = personId;
      this.number = number;
      this.type = type;
    }

    phoneId: number;
    personId: number;
    number: number;
    type: PhoneType;

  toString(): string {
    let numstr = this.number.toString();
    return `${PhoneType[this.type]}: (${numstr.substring(0,3)})${numstr.substring(2,5)}-${numstr.substring(6)}`;
  }
}
