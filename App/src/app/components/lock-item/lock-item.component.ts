import { Component, Input, OnInit } from '@angular/core';
import { LockDto } from 'src/app/models/LockDto';

@Component({
  selector: 'app-lock-item',
  templateUrl: './lock-item.component.html',
  styleUrls: ['./lock-item.component.scss']
})
export class LockItemComponent implements OnInit {
  @Input("lock") lock: LockDto;

  constructor() { 
  }

  ngOnInit(): void {
  }

}
