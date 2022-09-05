import { Component, Input, OnInit } from '@angular/core';
import { GroupDto } from 'src/app/models/GroupDto';

@Component({
  selector: 'app-group-item',
  templateUrl: './group-item.component.html',
  styleUrls: ['./group-item.component.scss']
})
export class GroupItemComponent implements OnInit {
  @Input("group") group: GroupDto;

  constructor() { }

  ngOnInit(): void {
  }

}
