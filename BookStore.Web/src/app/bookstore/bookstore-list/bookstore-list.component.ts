import { Component, OnInit } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { EventsService, EventStructure } from '../../services/events.service';

@Component({
  selector: 'app-bookstore-list',
  templateUrl: './bookstore-list.component.html',
  styleUrls: ['./bookstore-list.component.css']
})
export class BookstoreListComponent implements OnInit {

  bookList: any;

  constructor(private api: ApiService) {
    this.bookList = [];
  }

  ngOnInit() {
    this.getAll();
  }

  getAll() {
    this.api.setResource("book").get().subscribe(result => {
      this.bookList = result;
      this.bookList.sort(x => x.title);
    });
  }

  delete(book: any) {
    this.api.setResource("book").delete(book.id.increment).subscribe(result => {
      this.getAll();
    });
  }

  edit(book: any) {
    EventsService.getEventsEmitter().emit(new EventStructure("editBook", book));
  }
}
