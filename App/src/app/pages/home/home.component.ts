import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchLockService } from '../../services/search-lock.service';
import { LockDto } from 'src/app/models/LockDto';
import { SearchBuildingService } from 'src/app/services/search-building.service';
import { BuildingDto } from 'src/app/models/BuildingDto';
import { SearchGroupService } from 'src/app/services/search-group.service';
import { GroupDto } from 'src/app/models/GroupDto';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  searchLockService: SearchLockService;
  searchBuildingService: SearchBuildingService;
  searchGroupService: SearchGroupService;
  locks: LockDto[];
  entityOptions: string[] = ['Lock', 'Building', 'Medium', 'Group'];
  searchText: string = '';
  entity: string = 'Lock';
  buildings: BuildingDto[];
  groups: GroupDto[];

  constructor(
    private http: HttpClient,
    searchLockService: SearchLockService,
    searchBuildingService: SearchBuildingService,
    searchGroupService: SearchGroupService
  ) {
    this.searchLockService = searchLockService;
    this.searchBuildingService = searchBuildingService;
    this.searchGroupService = searchGroupService;
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
        this.searchBuildingService
          .getItems(this.searchText)
          .subscribe((items) => {
            this.buildings = items;
          });
        break;
      case 'Medium':
        break;
      case 'Group':
        this.searchGroupService.getItems(this.searchText).subscribe((items) => {
          this.groups = items;
        });
        break;
    }
  }
}
