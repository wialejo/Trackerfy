import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegisterComponent } from './register/register.component';
import {FormsModule} from "@angular/forms";
import {UsersRoutingModule} from "./users.routing-module";
import {AuthService} from "./auth.service";



@NgModule({
  declarations: [RegisterComponent],
  imports: [
    CommonModule,
    FormsModule,
    UsersRoutingModule
  ],
  providers:[AuthService]
})
export class UsersModule { }
