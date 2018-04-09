import { Injectable } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class ApiService {

  private _resource: string;
  private _apiDefault: string;

  constructor(private http: HttpClient) {
    this._apiDefault = "http://localhost:52839/api";
  }

  public get(id: string = ""): Observable<any> {
    let _url = this.makeBaseUrl(id);
    return this.http.get(_url);
  }

  public post(postBody: any): Observable<any> {
    let _url = this.makeBaseUrl();
    return this.http.post(_url, postBody);
  }

  public put(putBody: any): Observable<any> {
    let _url = this.makeBaseUrl();''
    return this.http.put(_url, putBody);
  }

  public delete(deleteBody: any, id: string = ""): Observable<any> {
    let _url = this.makeBaseUrl(id);
    return this.http.delete(_url);
  }

  private makeBaseUrl(id: string = ""): string {
    return `${this._apiDefault}/${this.getResource()}/${id}`;
  }

  public setResource(resource: string): ApiService {
    this._resource = resource.toLocaleLowerCase();
    return this;
  }

  public getResource(): string {
    if (this._resource == null)
      throw new Error('Resource not defined');
    return this._resource;
  }

  public getHeaders(): HttpHeaders {
    let headers = new HttpHeaders();
    headers.set('Access-Control-Allow-Origin', '*');
    headers.set("Content-Type", "application/json");
    return headers;
  }
}
