import { Component, Inject } from '@angular/core';
import { MAT_DIALOG_DATA, MatDialogRef } from '@angular/material/dialog';

@Component({
  selector: 'app-dialog-confirmation',
  templateUrl: './dialog-confirmation.component.html',
  styleUrls: ['./dialog-confirmation.component.css'],
})
export class DialogConfirmationComponent {
  constructor(
    public dialog: MatDialogRef<DialogConfirmationComponent>,
    @Inject(MAT_DIALOG_DATA) public title: string
  ) {}

  close(): void {
    this.dialog.close(false);
  }
  confirm(): void {
    this.dialog.close(true);
  }
}
