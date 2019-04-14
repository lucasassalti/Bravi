import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) {}

  getWeather(location){
    return this.http.get('http://api.openweathermap.org/data/2.5/forecast?id=524901&APPID=257b4b945153189928f7f02c17db3bb5&q=' + location);
  }
}
