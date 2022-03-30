import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';

import { Book } from 'src/app/Models/Book';
import { ServerResponse } from 'src/app/Models/ServerResponse';
import { BookServiceService } from 'src/app/Services/book-service.service';

@Component({
  selector: 'app-book-detail',
  templateUrl: './book-detail.component.html',
  styleUrls: ['./book-detail.component.css']
})
export class BookDetailComponent implements OnInit {
  id!: number;
  bookEdit!: Book;

formulario = new FormGroup({
  id: new FormControl('', Validators.required),
  title: new FormControl('', Validators.required),
  description: new FormControl('', Validators.required),
  pageCount: new FormControl('', Validators.required),
  excerpt: new FormControl('', Validators.required),
  publishDate: new FormControl('', Validators.required)
})
  constructor(private bookService: BookServiceService, private activatedRoute: ActivatedRoute) { }

  ngOnInit(): void {
    this.cargarFormulario();
  }

  cargarFormulario(): void{
    this.id =+ this.activatedRoute.snapshot.paramMap.get("id")!;
    this.bookService.getBook(this.id).subscribe(x => {
        this.bookEdit = x.data; 
        this.formulario.setValue(this.bookEdit)
        console.log(this.bookEdit);
    },
    (error: ServerResponse) => {
      alert('Error al cargar libro.');
    }
    )
  }

  editBook(): void{
    this.id =+ this.activatedRoute.snapshot.paramMap.get("id")!;
    let data = this.formulario.value;
    this.bookService.putBook(this.id, data).subscribe(x =>{console.log(x.data); this.formulario.reset();},
    (error: ServerResponse) =>{
      alert('Error al cargar libro.');
    });
  }

}
