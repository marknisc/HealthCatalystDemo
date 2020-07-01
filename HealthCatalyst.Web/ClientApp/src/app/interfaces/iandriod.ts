export interface IAndriod {
  phoneId: number;
  personId: number;
  number: number;
  type: PhoneType;
}

export enum PhoneType {
  None = 0,
  Mobile,
  Home,
  Office
}
