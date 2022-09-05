import { HttpClient, HttpHeaders } from '@angular/common/http';

export class DataService {
  private httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json' })
  }

  constructor(public url: string, public http: HttpClient) {
  }

  getAll() {
    return this.http.get(this.url);
  }

  create(model: any) {
    return this.http.post(this.url, JSON.stringify(model), this.httpOptions);
  }
}
