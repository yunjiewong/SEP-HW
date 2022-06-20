<h2 align="center">Routing</h2>

- Routing: move between different views

```
@NgModule({
    declarations:[AppComponent, ProductComponent, ...],
    imports: [BrowserModule, AppRoutingModule, ...],
    providers: [],
    bootstrap: [],
    exports: []
})
```
- AppModule: first default landing module
  - @NgModule: describe how to compile a component's template and how to create an injector at runtime
    - declarations: define components related to the module
    - imports: define other modules 
    - providers: inject the services
    - exports: share partial to other Ngmodule
 
- create components: ng g c ProductList (ng generate component)
- Connection components: AppRoutingModule
  - reason why it is single page application
  - different components but all on the same HTML page    
```
const routes: Routes = [
    {path:'', component:AppComponent},

    { path:'products', 
      children: [
        {path:'add', component: AddProductComponent},
        {path:'list', component:ProductListComponent},
        {path:'edit/:id',component:EditProductComponent}
      ]
    },
    {path:'**', component:PageNotFoundComponent},
 ],
```
-
    - {path:'edit/:id',component:EditProductComponent}
    - import { ActivatedRoute } from '@angular/router';
```
constructor(private activatedRoute:ActivatedRoute) 
  {   
      this.activatedRoute.params.subscribe(p=>{
        this.id = p["id"];
      });
  }

```

- one way binding
    - from component to HTML template 
        - interpolation: {{ProductName}}
        - property binding: [value]="ProductName"
    - from template to component:
        - event binding: (click)="addProduct()"
        
        
- two way binding
    -  import FormsModule in the app.modules.ts
        -  [(ngModule)] = "ProductName"

<hr>

<h4>1. interpolation</h4>
```
    <p>{{message}}</p>
    <p>{{messages.id}}</p>
    <p>{{messages.name}}</p>
```
<hr>
<h4>2. property binding</h4>
```
<input type="text" [value]="message"> 
<button type="button" [disabled]="isUnchanged">Disabled Button</button>
```
<hr>

<h4>3. event binding</h4>
```

<button type="button" (click)="ShowMessage()">Click</button>
```
<hr>
<h4>4.ngModel</h4>
```
<input [(ngModel)]="messages.name">
```
         
