
<h2 align="center"> Angular</h2>


#### 1. What is Single Page Application?
      Web app that is presented to the user through a single HTML page to be more responsive and 
      to more closely replicate a desktop application or a native app.
      
#### 2. What is typescript and how is it different from JavaScript?
    strongly typed programming language that builds on JavaScript,
    giving you better tooling at any scale.
    
#### 3. How do you create a two-way binding in Angular?
    ngModel
    Reactice form
    
#### 4. Did you use commands on angular CLI or only build and deployment? Which commands you have used in angular CLI?
    ng serve
    ng g n service/component 
    ng test

#### 5. What is the purpose of NgModule?
    organize the application, extend functionality from external libraries,
    and configure the compiler and injector
    contains declarations, imports, providers, and bootstrapping

#### 6. How you pass data from a parent component to a child component and vice versa and between unrelated Components?
     @Input() lets a parent component update data in the child component.
     @Output() lets the child send data to a parent component.

      Unrelated Components via a Service.


#### 7. Explain Angular Life cycle hooks with difference between ngOnInit and constructor.
     constructor: default method (do DI on Constructor )
     ngOnInit: Angular is done creating the component
     
     Constructor(DI)
         - ngOnChanges(): set or reset data properties
         - ngOnInit(): initialize
         - ngDoCheck(): 
                  - ngAfterContentInit()
                  - ngAfterContentChecked()
                  - ngAfterViewInit()
                  - ngAfterView Checked()
         - ngOnDestroy()
     


#### 8. What is angular View encapsulation?
      View encapsulation defines whether the template and styles defined within the component can affect the whole application or vice versa.
      @Component({
            encapsulation: ViewEncapsulation.None;
       })
       
       Emulated (default): styles from main HTML propagate to the component
       ShadowDom - styles from main HTML do not propagate to the component
       None - styles from the component propagate back to the main HTML and therefore are visible to all components on the page.
       

#### 9. What are directives, difference between structural directives and attribute directives?

            add additional behavior to elements in your Angular applications.
- Structural Directives
   -  ngFor
   -  ngIf
   -  ngSwitch
- Attribute Directives
   - ngClass
   - ngStyle
   - ngModel


#### 10. Difference between Template-driven forms and Reactive forms?
#### 11. How do you submit a form?
#### 12. What is the difference between NgForm, FormGroup and FormControl? How do they work together?
#### 13. What is the difference between dirty, touched, and pristine on a form element?
#### 14. How can you access validation errors in the template to display error messages?
#### 15. What is Async validation and how is it done?
#### 16. What is the purpose of using ngx-bootstrap or ng-bootstrap?
#### 17. How did you organize your Angular project? Explain the folder structure etc?
#### 18. Give me examples of built-in directives and custom directives you created
#### 19. What’s the purpose of pipe and how do you create custom pipes with examples from your project?
#### 20. Explain Angular Interceptors and their use case.
#### 21. What is an Angular Service? What are the features of Angular Service?
#### 22. How do you make Ajax calls in Angular (HttpClient in angular)?
#### 23. How did you handle exceptions in your Angular application?
#### 24. What is router-outlet directive in Angular? Explain how routing works in Angular and what are Route Guards? What’s the difference between CanActivate and CanLoad ?
#### 25. What are Observables? Where did you use them, explain forkJoin, combinelatest, mergemap operators in relation with Http and Angular?
#### 26. Explain difference between Promise and Observable.
#### 27. Do you what is Subject, BehaviorSubject ?
#### 28. Explain the Authentication process in your Angular application that includes JWT, Route Guards etc.
#### 29. How to improve the performance of Angular application, details of lazy loading, prefetch strategy, AOT etc.
#### 30. In your Angular application what did you do to display large amounts of Tabular data? Explain any third-part libraries you have used for table data and pagination
#### 31. What are your favorite 3rd party libraries in Angular ?
#### 32. Have you used ngx-charts and ngx-datatable in Angular?
#### 33. ngx-toastr, ngx-progressbar ?
