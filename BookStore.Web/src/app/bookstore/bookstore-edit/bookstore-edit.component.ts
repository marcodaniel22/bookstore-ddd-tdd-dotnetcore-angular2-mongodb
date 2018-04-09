import { Component, OnInit, Input } from '@angular/core';
import { ApiService } from '../../services/api.service';
import { EventsService, EventStructure } from '../../services/events.service';

@Component({
  selector: 'app-bookstore-edit',
  templateUrl: './bookstore-edit.component.html',
  styleUrls: ['./bookstore-edit.component.css']
})
export class BookstoreEditComponent implements OnInit {

  @Input() bookModel: any;

  constructor(private api: ApiService) {
    this.bookModel = {};
  }

  ngOnInit() {

  }

  save() {
    this.api.setResource("book").put({
      title: this.bookModel.title,
      author: this.bookModel.author,
      edition: this.bookModel.edition,
      publisher: this.bookModel.publisher,
      yearPublication: this.bookModel.yearPublication,
      price: this.bookModel.price,
      id: JSON.stringify(this.bookModel.id)
    }).subscribe(result => {
      this.bookModel = {};
      EventsService.getEventsEmitter().emit(new EventStructure("listBook"));
    });
  }
}
