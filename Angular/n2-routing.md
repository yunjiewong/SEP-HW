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
    }
 ],
```

