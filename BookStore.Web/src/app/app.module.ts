import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppComponent } from './app.component';
import { BookstoreComponent } from './bookstore/bookstore.component';
import { ApiService } from './services/api.service';
import {NgbModule, NgbActiveModal} from '@ng-bootstrap/ng-bootstrap';
import { BookstoreCreateComponent } from './bookstore/bookstore-create/bookstore-create.component';
import { BookstoreEditComponent } from './bookstore/bookstore-edit/bookstore-edit.component';
import { FormsModule } from '@angular/forms';
import { TabsComponent } from './tabs/tabs.component';
import { BookstoreListComponent } from './bookstore/bookstore-list/bookstore-list.component';
import { EventsService } from './services/events.service';


@NgModule({
  declarations: [
    AppComponent,
    BookstoreComponent,
    BookstoreListComponent,
    BookstoreCreateComponent,
    BookstoreEditComponent,
    TabsComponent,
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    ApiService,
    EventsService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
