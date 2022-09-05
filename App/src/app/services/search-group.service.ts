import { Injectable } from '@angular/core';
import { DataService } from './data.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GroupDto } from '../models/GroupDto';
import { AppSettings } from '../configuration/app-settings';

@Injectable({
  providedIn: 'root',
})
export class SearchGroupService extends DataService {
  constructor(http: HttpClient) {
    super(AppSettings.API_ENDPOINT, http);
  }

  getItems(searchText : string): Observable<GroupDto[]> {
    return this.http.get<GroupDto[]>(AppSettings.API_ENDPOINT + 'groups?searchBy=' + searchText);
  }
}

