import { TestBed } from '@angular/core/testing';

import { SearchMediaService } from './search-media.service';

describe('SearchLockService', () => {
  let service: SearchMediaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(SearchMediaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
