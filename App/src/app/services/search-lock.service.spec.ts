import { TestBed } from '@angular/core/testing';

import { SearchLockService } from './search-lock.service';

describe('SearchLockService', () => {
  let service: SearchLockService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SearchLockService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
