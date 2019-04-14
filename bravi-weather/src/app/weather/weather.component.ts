import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { ApiService } from '../api.service';

@Component({
  selector: 'app-weather',
  templateUrl: './weather.component.html',
  styleUrls: ['./weather.component.sass']
})
export class WeatherComponent implements OnInit {
  public weatherSearchForm: FormGroup;
  public weatherData: any;

  constructor(
    private formBuilder: FormBuilder,
    private apiService: ApiService) { }

  ngOnInit() {
    this.weatherSearchForm = this.formBuilder.group({
      location: ['']
    });
  }

  sendToApi(formLocation){
    this.apiService
          .getWeather(formLocation.location)
          .subscribe(data => {
            this.weatherData = data;
            console.log(this.weatherData);
          });
  }

}
