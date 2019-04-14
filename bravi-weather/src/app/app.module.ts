import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { WeatherComponent } from './weather/weather.component';
import { RouterModule, Router } from '@angular/router';
import { allAppRoutes } from './routes';
import { ReactiveFormsModule } from '@angular/forms';
import {  ApiService } from './api.service';



@NgModule({
  declarations: [
    AppComponent,
    WeatherComponent
  ],
  imports: [
    BrowserModule,
    RouterModule.forRoot(allAppRoutes),
    ReactiveFormsModule,
    HttpClientModule
  ],
  providers: [ApiService],
  bootstrap: [AppComponent]
})
export class AppModule { }
