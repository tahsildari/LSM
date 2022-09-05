import { Component, Input, OnInit } from '@angular/core';
import { LockModel } from 'src/app/models/LockModel';

@Component({
  selector: 'app-lock-item',
  templateUrl: './lock-item.component.html',
  styleUrls: ['./lock-item.component.scss']
})
export class LockItemComponent implements OnInit {
  @Input("lock") lock: LockModel;

  constructor() { 
  }

  ngOnInit(): void {
  }

}
