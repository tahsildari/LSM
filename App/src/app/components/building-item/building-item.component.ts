import { Component, Input, OnInit } from '@angular/core';
import { BuildingModel } from 'src/app/models/BuildingModel';

@Component({
  selector: 'app-building-item',
  templateUrl: './building-item.component.html',
  styleUrls: ['./building-item.component.scss']
})
export class BuildingItemComponent implements OnInit {
  @Input("building") building: BuildingModel;

  constructor() { }

  ngOnInit(): void {
  }

}
