import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BookstoreEditComponent } from './bookstore-edit.component';

describe('BookstoreEditComponent', () => {
  let component: BookstoreEditComponent;
  let fixture: ComponentFixture<BookstoreEditComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BookstoreEditComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookstoreEditComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
