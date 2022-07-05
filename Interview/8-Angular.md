
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
        Attribute Directives: Change the appearance or behavior of an element, component, or another directive.
        Structural Directives: Change the DOM layout by adding and removing DOM elements.
- Structural Directives
   -  ngFor: Repeat a node for each item in a list.
   -  ngIf: Conditionally creates or disposes of subviews from the template.
   -  ngSwitch: A set of directives that switch among alternative views.
- Attribute Directives
   - ngClass: Adds and removes a set of CSS classes.
   - ngStyle: Adds and removes a set of HTML styles.
   - ngModel: Adds two-way data binding to an HTML form element.


#### 10. Difference between Template-driven forms and Reactive forms?
      static vs. dynamic form.
      Template-driven: ngModel to data binding
      Reactive: FormGroup, FormController for data binding
      
#### 11. How do you submit a form?
      (submit)

#### 12. What is the difference between NgForm, FormGroup and FormControl? How do they work together?
      FormGroup is used with FormControl to track the value and validate the state of form control.
      
      ngForm = Template-Driven = asynchronous 
      FormGroup = Reactive Form = synchronous
      
      
#### 13. What is the difference between dirty, touched, and pristine on a form element?
      valid: This property returns true if the element’s contents are valid and false otherwise.
      invalid: This property returns true if the element’s contents are invalid and false otherwise.

      pristine: This property returns true if the element’s contents have not been changed.

      dirty: This property returns true if the element’s contents have been changed.
      untouched: This property returns true if the user has not visited the element.
      touched: This property returns true if the user has visited the element.

#### 14. How can you access validation errors in the template to display error messages?
      use ngIf directive to dectect elements' status
      <div *ngIf="myForm.controls['username'].invalid>  ....</div>
      
#### 15. What is Async validation and how is it done?
      the async version returns an Observable of the the same object
      async Validators is doing a server validation via an HTTP Callback
      
#### 16. What is the purpose of using ngx-bootstrap or ng-bootstrap?
           both are wrappers on regular bootstrap to support UI components in Angular applications. 
           
#### 17. How did you organize your Angular project? Explain the folder structure etc?
      app: components
      enviroment: API key
      guard: authentication guards
      interceptor: token interceptor
      interface: all properties of class
      services: for CRUD operations
      
#### 18. Give me examples of built-in directives and custom directives you created

#### 19. What’s the purpose of pipe and how do you create custom pipes with examples from your project?
      transform strings, currency amounts, dates, and other data for display. 

#### 20. Explain Angular Interceptors and their use case.
      intercept all the request and response calls and modify them to our requirement.
#### 21. What is an Angular Service? What are the features of Angular Service?
      objects that get instantiated just once during the lifetime of an application.
      They contain methods that maintain data throughout the life of an application, 
      i.e., data is available all the time
      

#### 22. How do you make Ajax calls in Angular (HttpClient in angular)?
      Ajax: Asynchronous JavaScript and XML

#### 23. How did you handle exceptions in your Angular application?
       provide an ErrorHandler class
#### 24. What is router-outlet directive in Angular? Explain how routing works in Angular and what are Route Guards? What’s the difference between CanActivate and CanLoad ?
      insert the component matched by routes to be displayed on the screen
      
      Angular's route guards are interfaces which can tell the router whether or not it should allow navigation to a requested route
      
      canActivate exists to prevent unauthorized users from accessing a route, 
      canLoad is used to prevent the application from loading an entire module 
      or component in a lazy way (lazy loading) if the user is not authorized

#### 25. What are Observables? Where did you use them, explain forkJoin, combinelatest, mergemap operators in relation with Http and Angular?
      Observables provide support for passing messages between parts of your application.


#### 26. Explain difference between Promise and Observable.
      Both observables and promises help us work with asynchronous functionality in JavaScript.
      Promises deal with one asynchronous event at a time
      observables handle a sequence of asynchronous events over a period of time.

#### 27. Do you what is Subject, BehaviorSubject ?

      In Subject, the subscribers will only receive the upcoming value. 
      In BehaviorSubject, the subscribers will receive the previous value and also upcoming value.

#### 28. Explain the Authentication process in your Angular application that includes JWT, Route Guards etc.
      Step 1 - The Login Page
      Step 2 - Creating a JWT-based user Session
      Step 3 - Sending a JWT back to the client
      Step 4 - Storing and using the JWT on the client side
      Step 5 - Sending The JWT back to the server on each request
      Step 6 - Validating User Requests
      
      
#### 29. How to improve the performance of Angular application, details of lazy loading, prefetch strategy, AOT etc.

#### 30. In your Angular application what did you do to display large amounts of Tabular data? Explain any third-part libraries you have used for table data and pagination
      ngx-datatable is an Angular component for presenting large and complex data.
#### 31. What are your favorite 3rd party libraries in Angular ?
#### 32. Have you used ngx-charts and ngx-datatable in Angular?

#### 33. ngx-toastr, ngx-progressbar ?
