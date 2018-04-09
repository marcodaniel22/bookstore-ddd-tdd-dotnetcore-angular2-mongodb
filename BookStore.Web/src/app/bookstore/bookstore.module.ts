import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BookstoreComponent } from './bookstore.component';
import { BookstoreCreateComponent } from './bookstore-create/bookstore-create.component';
import { BookstoreEditComponent } from './bookstore-edit/bookstore-edit.component';
import { BookstoreListComponent } from './bookstore-list/bookstore-list.component';

@NgModule({
  imports: [
    CommonModule
  ],
  declarations: [BookstoreComponent, BookstoreCreateComponent, BookstoreEditComponent, BookstoreListComponent]
})
export class BookstoreModule { }
