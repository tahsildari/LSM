import { Injectable } from '@angular/core';
import { DataService } from './data.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LockDto } from '../models/LockDto';
import { AppSettings } from '../configuration/app-settings';

@Injectable({
  providedIn: 'root',
})
export class SearchLockService extends DataService {
  constructor(http: HttpClient) {
    super('https://localhost:49157/', http);
  }

  getItems(): Observable<LockDto[]> {
    return this.http.get<LockDto[]>(AppSettings.API_ENDPOINT + 'locks?searchBy=off');
  }
}
