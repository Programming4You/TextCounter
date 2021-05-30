import { Component, OnInit } from '@angular/core';
import { Text } from '../shared/models/text.model';
import { WordService } from '../shared/services/word.service';
import { FileValidation } from '../shared/validation/file-validation';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-file',
  templateUrl: './file.component.html',
  styleUrls: ['./file.component.css']
})
export class FileComponent implements OnInit {
  text: Text;
  
  constructor(private wordService: WordService, private toastr: ToastrService) { }

  ngOnInit(): void {
  }

  getFileInput(event: any) {
    const file = event.target.files[0];

    if(!FileValidation.isTextFile(file)) {
      this.toastr.error("Allowed file format: .txt");
      return;
    }

    const reader = new FileReader();
    reader.readAsDataURL(file);
    reader.onload = () => {

      let base64string = reader.result.toString();
      var output = base64string.split(/[, ]+/).pop();

      let requestBody = {
        fileInBase64String: output
      }
      this.wordService.getTextFromFile(requestBody).subscribe(res => {
        this.text = res;
      }, err => {
        console.log(err);
      })
    };
  }

}
