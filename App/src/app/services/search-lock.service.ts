import { Injectable } from '@angular/core';
import { DataService } from './data.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LockModel } from '../models/LockModel';
import { AppSettings } from '../configuration/app-settings';

@Injectable({
  providedIn: 'root',
})
export class SearchLockService extends DataService {
  constructor(http: HttpClient) {
    super(AppSettings.API_ENDPOINT, http);
  }

  getItems(searchText : string): Observable<LockModel[]> {
    return this.http.get<LockModel[]>(AppSettings.API_ENDPOINT + 'locks?searchBy=' + searchText);
  }
}
