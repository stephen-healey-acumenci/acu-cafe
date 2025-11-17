import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

interface Order {
  type: string;
  hasMilk: boolean;
  hasSugar: boolean;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'acucafe';
  showSummary = false;
  hasMilk = false;
  hasSugar = false;
  selectedQuantity: number = 0;
  selectedDrink: string = '';
  order: Order | null = null;

  drinks = ['Tea', 'Coffee', 'Ice Tea'];
  summaryList: string[] = [];
  quantities = [1, 2, 3, 4, 5, 6, 7, 8, 9];

  http: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
  }

  processOrder() {
      this.showSummary = false;
      for (let i = 0; i < this.selectedQuantity; i++) {

      let order: Order = {
        type: this.selectedDrink,
        hasMilk: this.hasMilk,
        hasSugar: this.hasSugar
      };

      this.http.post(this.baseUrl + 'acucafe', order, {responseType: 'text'}).subscribe(result => {
        this.summaryList.push(result);
        console.log(this.summaryList);
        this.showSummary = true;
      });
    }

  }
}
