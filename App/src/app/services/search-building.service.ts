import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { AppSettings } from '../configuration/app-settings';
import { BuildingModel } from '../models/BuildingModel';
import { DataService } from './data.service';

@Injectable({
  providedIn: 'root'
})
export class SearchBuildingService extends DataService  {

  constructor(http: HttpClient) {
    super(AppSettings.API_ENDPOINT, http);
  }

  getItems(searchText : string): Observable<BuildingModel[]> {
    return this.http.get<BuildingModel[]>(AppSettings.API_ENDPOINT + 'buildings?searchBy=' + searchText);
  }
}
