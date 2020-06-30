export interface IAndriod {
  PhoneId: number;
  PersonId: number;
  Number: number;
  PhoneType: PhoneType;
}

export enum PhoneType {
  None = 0,
  Mobile,
  Home,
  Office
}
