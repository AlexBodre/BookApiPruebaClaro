import { Component, OnInit } from '@angular/core';
import { Book } from 'src/app/Models/Book';
import { ServerResponse } from 'src/app/Models/ServerResponse';
import { BookServiceService } from 'src/app/Services/book-service.service';

@Component({
  selector: 'app-book-list',
  templateUrl: './book-list.component.html',
  styleUrls: ['./book-list.component.css']
})
export class BookListComponent implements OnInit {
    searchId!: number;
    bookList: Book[] = [];

  constructor(private bookService: BookServiceService) { }

  ngOnInit(): void {
    this.getBooksList();
  }

  getBooksList(): void{
    this.bookService.getBooks().subscribe(x => {this.bookList = x.data;},
      (error)=>{alert(error.message);})
  }

  deleteBook(id: number):void{
    if (confirm("Seguro que quiere eliminar este libro?")){
      this.bookService.deleteBook(id).subscribe(x => {alert(x.data);
        (error: ServerResponse) => {
          alert('Error al cargar libro.');
        }
      },
      )};
  }

  search(){
    if(this.searchId > 0){
      const search = this.bookList.filter(x => x.id === this.searchId);
      this.bookList = search;
    }
  }

  clearSearch(){
    this.getBooksList();
  }


}
