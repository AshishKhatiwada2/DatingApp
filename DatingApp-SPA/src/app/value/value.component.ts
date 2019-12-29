import {  OnInit, Component} from '@angular/core';
import { HttpClient } from '@angular/common/http';


@Component({
    selector: 'app-value',
    templateUrl: './value.component.html',
    styleUrls : ['./value.component.css']
})

export class ValueComponent implements OnInit {
    values: any;
    names: any = 'ashish angular data displayed';
    constructor(private http: HttpClient ) {}
        ngOnInit(): void {
            this.getValues();
        }
    getValues() {
        this.http.get('http://localhost:5000/values')
        .subscribe(
            Response => {this.values = Response; },
            error => {console.log(error); }
        );
    }
}
