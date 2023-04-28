import { Component } from '@angular/core';
import { AccountService } from '../_services/account.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.css']
})
export class NavComponent {

  model: any = {};

  constructor(private accountService: AccountService) {
  }

  login() {
    this.accountService.login(this.model).subscribe({
      next: response => {
        console.log(response)
      },
      error: err => console.log(err),
      complete: () => console.log('Login Successfully!')
    })
  }

}
