import { TestBed } from '@angular/core/testing';

import { SearchBuildingService } from './search-building.service';

describe('SearchBuildingService', () => {
  let service: SearchBuildingService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SearchBuildingService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
