import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
   
 
})  

export class AppComponent {

  n1: number = 10;    
    n2: number = 20;  
    
  
  items: item[] = [{name: 'priscilla', id: 101}, {name: 'lily', id: 102}, {name: 'Monica', id: 103}];  
  selectedValue: string= 'priscilla'; 
  title = 'AngularDirectives';
  subtitle = 'College-Campus';
  student : any[]=[
    {Name:'Prasanth',Branch:'CSE', Marks:'100'},
  {Name:'Priscilla',Branch:'MCA', Marks:'150'},
  {Name:'Blessy',branch:'ECE', Marks:'90'},
  {Name:'Lily',Branch:'EEE', Marks:'200'},
]

}
class item {  
  name: string;  
  id: number;  
}  
 
class student
{
  Name:string;
  Branch:string;
  Marks:Number;
}