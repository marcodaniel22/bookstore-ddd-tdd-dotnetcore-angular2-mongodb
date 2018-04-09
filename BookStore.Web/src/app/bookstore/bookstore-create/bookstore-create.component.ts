import { Component, OnInit, ElementRef } from '@angular/core';
import { ApiService } from '../../services/api.service';

@Component({
  selector: 'app-bookstore-create',
  templateUrl: './bookstore-create.component.html',
  styleUrls: ['./bookstore-create.component.css']
})
export class BookstoreCreateComponent implements OnInit {

  bookModel: any;

  constructor(private api : ApiService) {
    this.bookModel = {};
   }

  ngOnInit() {

  }

  save() {
    this.api.setResource("book").post(this.bookModel).subscribe(result => {
      this.bookModel = {};
    });
  }
}
