import { Component, OnInit, EventEmitter } from '@angular/core';
import { EventStructure, EventsService } from '../services/events.service';

@Component({
  selector: 'app-tabs',
  templateUrl: './tabs.component.html',
  styleUrls: ['./tabs.component.css']
})
export class TabsComponent implements OnInit {

  onList: boolean;
  onCreate: boolean;
  onEdit: boolean;
  events: EventEmitter<EventStructure>;
  bookEdit: any;

  constructor() {
    this.onList = true;
    this.onCreate = false;
    this.onEdit = false;
  }

  ngOnInit() {
    this.events = EventsService.getEventsEmitter().subscribe(e => {
      if (e.event == "editBook") {
        this.bookEdit = e.data;
        this.changeTab(2);
      }
      if (e.event == "listBook") {
        this.changeTab(0);
      }
    });
  }

  changeTab(tabIndex: any) {
    this.disableAll();
    switch (tabIndex) {
      case 0:
        this.bookEdit = null;
        this.onList = true;
        break;
      case 1:
        this.onCreate = true;
        break;
      case 2:
        this.onEdit = true;
        break;
    }
  }

  disableAll() {
    this.onList = false;
    this.onCreate = false;
    this.onEdit = false;
  }
}
