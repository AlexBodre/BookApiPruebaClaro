import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BookListComponent } from './Components/book-list/book-list.component';
import { BookCreateComponent } from './Components/book-create/book-create.component';

@NgModule({
  declarations: [
    AppComponent,
    BookListComponent,
    BookCreateComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
