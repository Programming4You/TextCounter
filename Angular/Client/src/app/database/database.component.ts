import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Text } from '../shared/models/text.model';
import { WordService } from '../shared/services/word.service';

@Component({
  selector: 'app-database',
  templateUrl: './database.component.html',
  styleUrls: ['./database.component.css']
})
export class DatabaseComponent implements OnInit {
  textList:Text[];
  userInputText:string;

  constructor(private wordService: WordService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  getTexts(){
    this.wordService.getTextList().subscribe(res => {
      this.textList = res;
    }, err => {
      console.log(err);
    })
  }

  createData(){
    if(!this.userInputText){
      this.toastr.warning("You must imput some content");
      return;
    }

    let requestBody = {
      content: this.userInputText
    }
    this.wordService.createText(requestBody).subscribe(res => {
      this.getTexts();
      this.userInputText = '';
    }, err => {
      console.log(err);
    })
  }

}
