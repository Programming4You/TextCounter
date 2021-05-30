import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { WordComponent } from './words/word/word.component';

const routes: Routes = [
  { path: '', component: HomeComponent },
  { path: 'word', component: WordComponent },
  { path: '**', component: WordComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
