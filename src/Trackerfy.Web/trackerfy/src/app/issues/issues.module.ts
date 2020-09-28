import {NgModule} from '@angular/core';
import {CommonModule} from '@angular/common';
import {IssuesListComponent} from "./issues-container/issues-list/issues-list.component";
import {IssuesService} from "./issues.service";
import {IssuesRoutingModule} from "./issues.routing-module";
import {IssuesContainerComponent} from './issues-container/issues-container.component';
import {CreateIssueComponent} from './create-issue/create-issue.component';
import {NgbModule} from "@ng-bootstrap/ng-bootstrap";
import {IssueTypesModule} from "../issue-types/issue-types.module";
import {FormsModule, ReactiveFormsModule} from "@angular/forms";
import {IssueDetailsComponent} from "./issues-container/issue-details/issue-details.component";


@NgModule({
  declarations: [IssuesContainerComponent, IssuesListComponent, CreateIssueComponent, IssueDetailsComponent,],
  imports: [
    CommonModule,
    IssuesRoutingModule,
    NgbModule,
    IssueTypesModule,
    FormsModule,
    ReactiveFormsModule,
  ],
  providers: [IssuesService, IssuesListComponent],
  bootstrap: [IssuesContainerComponent]
})
export class IssuesModule {
}
