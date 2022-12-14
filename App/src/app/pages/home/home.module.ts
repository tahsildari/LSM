import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { HttpClientModule } from '@angular/common/http';
import { LockItemComponent } from 'src/app/components/lock-item/lock-item.component';
import { BuildingItemComponent } from 'src/app/components/building-item/building-item.component';
import { GroupItemComponent } from 'src/app/components/group-item/group-item.component';
import { MediaItemComponent } from 'src/app/components/media-item/media-item.component';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [HomeComponent, 
    LockItemComponent, 
    BuildingItemComponent,
    GroupItemComponent,
    MediaItemComponent],
  imports: [CommonModule, HomeRoutingModule, HttpClientModule, FormsModule],
})
export class HomeModule {}
