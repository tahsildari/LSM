import { Component, OnInit } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { SearchLockService } from '../../services/search-lock.service';
import { LockModel } from 'src/app/models/LockModel';
import { SearchBuildingService } from 'src/app/services/search-building.service';
import { BuildingModel } from 'src/app/models/BuildingModel';
import { SearchGroupService } from 'src/app/services/search-group.service';
import { GroupModel } from 'src/app/models/GroupModel';
import { MediaModel } from 'src/app/models/MediaModel';
import { SearchMediaService } from 'src/app/services/search-media.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss'],
})
export class HomeComponent implements OnInit {
  searchLockService: SearchLockService;
  searchBuildingService: SearchBuildingService;
  searchGroupService: SearchGroupService;
  searchMediaService: SearchMediaService;
  locks: LockModel[];
  entityOptions: string[] = ['Lock', 'Building', 'Medium', 'Group'];
  searchText: string = '';
  entity: string = 'Lock';
  buildings: BuildingModel[];
  groups: GroupModel[];
  media: MediaModel[];

  constructor(
    private http: HttpClient,
    searchLockService: SearchLockService,
    searchBuildingService: SearchBuildingService,
    searchGroupService: SearchGroupService,
    searchMediaService: SearchMediaService
  ) {
    this.searchLockService = searchLockService;
    this.searchBuildingService = searchBuildingService;
    this.searchGroupService = searchGroupService;
    this.searchMediaService = searchMediaService;
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
        this.searchMediaService.getItems(this.searchText).subscribe((items) => {
        this.media = items;
      });
        break;
      case 'Group':
        this.searchGroupService.getItems(this.searchText).subscribe((items) => {
          this.groups = items;
        });
        break;
    }
  }
}
