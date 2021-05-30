import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Text } from '../models/text.model';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class WordService {

  constructor(private http: HttpClient) { }

  httpOptions = {
    headers: new HttpHeaders({
      'Content-Type':'application/json'
    })
  }

  getTextList():Observable<Text[]>{
    return this.http.get<Text[]>(environment.apiURL+'/Text');
  }

  createText(text:any):Observable<Text>{
    const body = JSON.stringify(text);
    return this.http.post<Text>(environment.apiURL+'/Text', body, this.httpOptions);
  }


  getText(text:any):Observable<Text>{
    const body = JSON.stringify(text);
    return this.http.post<Text>(environment.apiURL+'/UserInput', body, this.httpOptions);
  }


  getTextFromFile(base64:any):Observable<Text>{
    const body = JSON.stringify(base64);
    return this.http.post<Text>(environment.apiURL+'/FileInput', body, this.httpOptions);
  }



}
