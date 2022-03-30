import { Injectable } from '@angular/core';
import { catchError, Observable, of } from 'rxjs';

import { HttpClient, HttpErrorResponse, HttpParams } from '@angular/common/http';
import { ServerResponse } from '../Models/ServerResponse';
import { environment } from 'src/environments/environment';
import { Book } from '../Models/Book';


@Injectable({
  providedIn: 'root'
})
export class BookServiceService {
  
  constructor(private http : HttpClient) { }

  getBooks(): Observable<ServerResponse>{
    return this.http.get<ServerResponse>(environment.apiUrl + '/Books');
  }
  getBook(Id: number): Observable<ServerResponse>{
    return this.http.get<ServerResponse>(environment.apiUrl + `/Books/${Id}`);

  }
  postBook(book: Book): Observable<ServerResponse>{
    return this.http.post<ServerResponse>(environment.apiUrl + '/Books', book);
  }
  putBook(id: number, book: Book): Observable<ServerResponse>{
    return this.http.put<ServerResponse>(environment.apiUrl + `/Books/${id}`, book);
  }
  deleteBook(Id: number): Observable<ServerResponse>{
    return this.http.delete<ServerResponse>(environment.apiUrl + `/Books/${Id}`);
  }

  formatError(err: HttpErrorResponse){
    const error = err.error as any;
    return of((error as ServerResponse));
  }
}
