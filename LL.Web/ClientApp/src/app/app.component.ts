import { coerceNumberProperty } from '@angular/cdk/coercion';
import { Component, OnInit } from '@angular/core';
import { MatSnackBar } from '@angular/material/snack-bar';
import { SessionService } from './services/session.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {
  inputObj = {
    lastActive: 3,
    sessions: 33,
    sessionDuration: 28,
    clicks: 560,
    mailOffender: 1,
    notSpammed: 1
  };

  confidence = null;

  constructor(
    private sessionService: SessionService,
    private _snackBar: MatSnackBar
  ) {}

  ngOnInit() {
    this.compute();
  }

  compute() {
    this.sessionService.getScore(this.inputObj).subscribe(
      data => {
        this.confidence = data;
      },
      error => {
        this._snackBar.open('Invalid Input', 'Dismiss', {
          duration: 2000
        });
      }
    );
  }
}
