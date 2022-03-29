import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';

import { HttpClient, HttpParams } from '@angular/common/http';
import { ServerResponse } from '../Models/ServerResponse';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BookServiceService {
  
  constructor(private http : HttpClient) { }

  getBooks(): Observable<ServerResponse>{
    return this.http.get<ServerResponse>(environment.apiUrl);
  }

  getBook(Id: number): Observable<ServerResponse>{
    return this.http.get<ServerResponse>(environment.apiUrl + `/Books/${Id}`);
  }
}
