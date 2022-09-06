import { Injectable } from '@angular/core';
import { DataService } from './data.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { MediaModel } from '../models/MediaModel';
import { AppSettings } from '../configuration/app-settings';

@Injectable({
  providedIn: 'root',
})
export class SearchMediaService extends DataService {
  constructor(http: HttpClient) {
    super(AppSettings.API_ENDPOINT, http);
  }

  getItems(searchText : string): Observable<MediaModel[]> {
    return this.http.get<MediaModel[]>(AppSettings.API_ENDPOINT + 'media?searchBy=' + searchText);
  }
}
