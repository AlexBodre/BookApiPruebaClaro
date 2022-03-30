import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Book } from 'src/app/Models/Book';
import { ServerResponse } from 'src/app/Models/ServerResponse';
import { BookServiceService } from 'src/app/Services/book-service.service';

@Component({
  selector: 'app-book-create',
  templateUrl: './book-create.component.html',
  styleUrls: ['./book-create.component.css']
})
export class BookCreateComponent implements OnInit {

bookList: Book[] = [];

formulario = new FormGroup({
  title: new FormControl('', Validators.required),
  description: new FormControl('', Validators.required),
  pageCount: new FormControl('', Validators.required),
  excerpt: new FormControl('', Validators.required),
  publishDate: new FormControl('', Validators.required)
})

  constructor(private bookService: BookServiceService ) { }

  ngOnInit(): void {
  }

  newBook() {
    let data = this.formulario.value;
    this.bookService.postBook(data).subscribe(data => {console.log(data); alert(data.message)
      this.formulario.reset();},
    (error: ServerResponse) => { alert(error.message);
    });
}
}
