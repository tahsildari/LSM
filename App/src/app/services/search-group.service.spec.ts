import { TestBed } from '@angular/core/testing';

import { SearchGroupService } from './search-group.service';

describe('SearchGroupService', () => {
  let service: SearchGroupService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SearchGroupService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
