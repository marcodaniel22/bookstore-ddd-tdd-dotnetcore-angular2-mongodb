import { Injectable, EventEmitter } from '@angular/core';

@Injectable()
export class EventsService {

  static events = new EventEmitter<EventStructure>();

  constructor() { }

  public static getEventsEmitter() {
    if (!this.events)
      this.events = new EventEmitter<EventStructure>();
    return this.events;
  }
}

export class EventStructure {

  public event: string;
  public data?: any;

  constructor(_event: string, _data?: any) {
    this.event = _event;
    this.data = _data;
  }
}
