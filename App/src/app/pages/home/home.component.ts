import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchLockService } from '../../services/search-lock.service';
import { LockDto } from 'src/app/models/LockDto';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  searchLockService: SearchLockService;
  locks: LockDto[];
  entityOptions: string[] = ['Lock', 'Building', 'Medium', 'Group'];
  searchText: string = '';

  constructor(private http: HttpClient, searchLockService: SearchLockService) {
    this.searchLockService = searchLockService;
  }

  ngOnInit(): void {}

  search() {
    this.searchLockService.getItems(this.searchText).subscribe((locks) => {
      this.locks = locks;
    });
  }
}
