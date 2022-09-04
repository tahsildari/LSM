import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  constructor(private http: HttpClient) { }

  ngOnInit(): void {
  }

  search(){
    let courses = this.http
    .get<Course[]>("https://localhost:49157/building?searchBy=" + )
    .map(data => _.values(data))
    .do(console.log);
  }
}
