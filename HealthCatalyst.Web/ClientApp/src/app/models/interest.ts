import { IInterest } from '../interfaces/iinterest';

export class Interest implements IInterest {
    constructor(interestId: number, personId: number, desc: string){
        this.interestId = interestId;
        this.personId = personId;
        this.description = desc;
    }
    interestId: number;
    personId: number;
    description: string;
}
