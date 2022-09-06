import { Component, Input, OnInit } from '@angular/core';
import { MediaModel } from 'src/app/models/MediaModel'

@Component({
  selector: 'app-media-item',
  templateUrl: './media-item.component.html',
  styleUrls: ['./media-item.component.scss']
})
export class MediaItemComponent implements OnInit {
  @Input("medium") medium: MediaModel;

  constructor() { }

  ngOnInit(): void {
  }

}
