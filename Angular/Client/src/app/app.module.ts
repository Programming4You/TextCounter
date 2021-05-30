import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { WordComponent } from './words/word/word.component';
import { HomeComponent } from './home/home.component';
import { FormsModule } from '@angular/forms';
import { FileComponent } from './file/file.component';
import { DatabaseComponent } from './database/database.component';
import { FooterComponent } from './shared/footer/footer.component';
import { ToastrModule } from 'ngx-toastr';
import { AppMaterialModule } from './app-material.module';
import { HeaderComponent } from './shared/header/header.component';


@NgModule({
  declarations: [
    AppComponent,
    WordComponent,
    HomeComponent,
    FileComponent,
    DatabaseComponent,
    FooterComponent,
    HeaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    BrowserAnimationsModule,
    FormsModule,
    ToastrModule.forRoot({
      maxOpened: 1,
      autoDismiss: true
    }),
    AppMaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
