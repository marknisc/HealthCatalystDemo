import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { IAppConfig } from '../interfaces/config';

@Injectable({
  providedIn: 'root'
})
export class ConfigService {
  static settings : IAppConfig;
  
  constructor(private http: HttpClient) { }
  
  load() : Promise<void>{
    console.log("configSvc load")
    const configFile = `assets/config/config.${environment.name}.json`;

    return new Promise<void>((resolve, reject) => {
        this.http.get(configFile).toPromise().then((response : IAppConfig) => {
          ConfigService.settings = <IAppConfig>response;
          resolve();
        }).catch((response: any) => {
          reject(`Could not load file '${configFile}': ${JSON.stringify(response)}`);
        });
    });
  }
}
