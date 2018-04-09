import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BookstoreCreateComponent } from './bookstore-create.component';

describe('BookstoreCreateComponent', () => {
  let component: BookstoreCreateComponent;
  let fixture: ComponentFixture<BookstoreCreateComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BookstoreCreateComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BookstoreCreateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
