import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BookListComponent } from './Components/book-list/book-list.component';
import { BookCreateComponent } from './Components/book-create/book-create.component';
import { BookDetailComponent } from './Components/book-detail/book-detail.component';
const routes: Routes = [
  {
    path:'books',
    pathMatch: 'full',
    component: BookListComponent,
    
  },
  {
    path:'books/add',
    pathMatch: 'full',
    component: BookCreateComponent,
  },
  {
    path:'books/:id',
    pathMatch: 'full',
    component: BookDetailComponent,
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
