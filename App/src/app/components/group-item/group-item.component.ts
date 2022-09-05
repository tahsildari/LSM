import { Component, Input, OnInit } from '@angular/core';
import { GroupModel } from 'src/app/models/GroupModel';

@Component({
  selector: 'app-group-item',
  templateUrl: './group-item.component.html',
  styleUrls: ['./group-item.component.scss']
})
export class GroupItemComponent implements OnInit {
  @Input("group") group: GroupModel;

  constructor() { }

  ngOnInit(): void {
  }

}
