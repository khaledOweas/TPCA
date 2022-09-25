import { Component, OnInit } from '@angular/core';
import { LoadingService } from './loading.service';
import { delay } from 'rxjs/operators';
@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  title = 'app';
  loading: boolean = true;
  constructor(private _loading: LoadingService) {

  }
  ngOnInit(): void {
    this.listenToLoading();
  }

  listenToLoading(): void {
    console.log(this.loading);
    this._loading.loadingSub
      .pipe(delay(0))
      .subscribe((loading) => {
        console.log(this.loading);
        this.loading = loading;
      });
  }
}
