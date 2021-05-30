import { Component, OnInit } from '@angular/core';
import { ToastrService } from 'ngx-toastr';
import { Text } from 'src/app/shared/models/text.model';
import { WordService } from 'src/app/shared/services/word.service';


@Component({
  selector: 'app-word',
  templateUrl: './word.component.html',
  styleUrls: ['./word.component.css']
})
export class WordComponent implements OnInit {
  textList:Text[];
  text:Text;
  userInput:string;

  constructor(private wordService: WordService, private toastr: ToastrService) { }

  ngOnInit(): void {

  }

  countWords() {
    if(!this.userInput){
      this.toastr.warning("Imput some content");
      return;
    }

    let requestBody = {
      content: this.userInput
    }
    this.wordService.getText(requestBody).subscribe(res => {
      this.text = res;
    }, err => {
      console.log(err);
    })
  }

}
