import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchLockService } from '../../services/search-lock.service';
import { LockDto } from 'src/app/models/LockDto';
import { SearchBuildingService } from 'src/app/services/search-building.service';
import { BuildingDto } from 'src/app/models/BuildingDto';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  searchLockService: SearchLockService;
  searchBuildingService: SearchBuildingService;
  locks: LockDto[];
  entityOptions: string[] = ['Lock', 'Building', 'Medium', 'Group'];
  searchText: string = '';
  entity: string = 'Lock';
  buildings: BuildingDto[];

  constructor(
    private http: HttpClient, 
    searchLockService: SearchLockService,
    searchBuildingService: SearchBuildingService) {
    this.searchLockService = searchLockService;
    this.searchBuildingService = searchBuildingService;
  }

  ngOnInit(): void {}

  search() {
    switch (this.entity) {
      case 'Lock':
        this.searchLockService.getItems(this.searchText).subscribe((items) => {
          this.locks = items;
        });
        break;
      case 'Building':
        this.searchBuildingService.getItems(this.searchText).subscribe((items) => {
          console.table(items)
          this.buildings = items;
        });
        break;
      case 'Medium':
        break;
      case 'Group':
        break;
    }
  }
}
