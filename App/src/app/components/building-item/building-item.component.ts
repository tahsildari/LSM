import { Component, Input, OnInit } from '@angular/core';
import { BuildingDto } from 'src/app/models/BuildingDto';

@Component({
  selector: 'app-building-item',
  templateUrl: './building-item.component.html',
  styleUrls: ['./building-item.component.scss']
})
export class BuildingItemComponent implements OnInit {
  @Input("building") building: BuildingDto;

  constructor() { }

  ngOnInit(): void {
  }

}
