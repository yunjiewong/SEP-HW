<h2 align="center">Interview Questions</h2>

#### C# and .NET Core

##### 1. What are differences between .NET Framework and .NET Core.
  - Framework can only create serve-based application on Windows.
  - .Net Core is cross platform


##### 2. Can you explain some new features from C# 7, 8,9 and 10 version?
  - 7: out variables, pattern matching, local function...
  - 8: readonly members, default interface methods (major)
  - 9: support for code generator
  - 10: record struct
  - https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-version-history

##### 3. What is garbage collector? What is its purpose? What are the different generations in garbage collector?
  - an automatic memory manager
  - GC considers unreachable objects garbage and releases the memory allocated for them
  - f
  - 


##### 4. What is the difference between value type and reference type variables? What is boxing and unboxing in reference type variable?
  - boxing: 
##### 5. What is meant by the terms managed resource and unmanaged resource in .NET
##### 6. What is IDisposable interface and it’s dispose method, does it depend on garbage collector and where would you use IDisposable interface?
##### 7. What is Reflection? Give me examples of where you have used Reflection?
##### 8. Explain Serialization and how can we achieve XML and JSON serialization
##### 9. Explain different access modifiers in C#?
● public
● private
● protected
● internal
● protected internal
● private protected
##### 10.Explain following keywords in C#
● static
● var
● sealed
● const vs readonly
● ref vs out
● yield
● record
● partial
● try catch finally
● using statement and using directive
● abstract
● override
● dynamic
#### 11. Explain scenarios where you would use String vs StringBuilder?
  - stringbuilder for string manipulation
12. Explain Object-Oriented Concepts (OOPS) in .NET with examples from your project
● Abstraction
● Encapsulation
● Inheritance
● Polymorphism

#### 13. Compare virtual methods and abstract methods?
  - abstract only implementation
#### 14. Differences between overloading and overriding?
  - overloading method: constructor, 
  - overriding: same signature
#### 15. What are generics and tell me scenarios where you have generics in your projects? What does generic constraints do?
  - generics: any class type
  - generic constraints: for specific class type
  - 
#### 16. What is the difference between a generic and a non-generic collection? What are the different collection classes in C#?
  - non-generic collection: arraylist
  - generic collection: array list
  
#### 17. Why do you think we need an abstract class, why do you need an interface? Give few examples, where you have used abstract classes and interfaces in your project.
  - hide the actual implementation

#### 18. What are extension methods and give me examples of built-in extension methods. Have you created an extension method in your project? If yes, how with examples?

#### 19. What are lambda expressions, where have u used lambda expressions
  - simplify the code
  - 
#### 20. Tell what is LINQ? And give me scenarios where you have used LINQ in your projects.


#### 21. Differed Execution and immediate execution in LINQ?
#### 22. Write LINQ, GroupBy, Join, and Where conditions.
#### 23. Differences between First, FirstOrDefault, Single, SingleOrDefault in LINQ
  - 
#### 24. Anonymous types and methods
  - new {}
  
#### 25. What are delegates in .NET, and can you tell differences between Func, Action and Predicate.
  - different return types: Action null, func returns any, predicate returns boolean


#### 26. What is difference between IEnumerable and IQueryable
  - 
#### 27. Explain async and await keywords in C#. Give me scenarios where you have you used in your projects?
  - asynchronous programming for fast computution
  - 
#### 28. Do you know how can we make HTTP Requests in C#? Can you explain what IHttpContextAccessor is?
#### 29. Difference between Task vs Thread vs Process

#### 30. What does lock keyword does? Give me example of it where you have used?

#### 31. Can you tell difference between Task.WhenAll and Task.WhenAny?

#### 32. What’s is the purpose of ConfigureAwait() ?

#### 33. What’s the difference between asynchronous programming and Multithreaded programming?

<hr>

#### ASP.NET Core

#### 1. What is Kestrel? How to use Kestrel in asp.net Core application?

#### 2. What is asp.net core Middleware and How it is different from HttpModule? What are some built-in middleware(s) with asp.net Core?
#### 3. What are some custom Middlewares you created? How did you register them?
  - app.addmiddleware
#### 4. What does Configure () and ConfigureServices () methods do Startup.cs do?

#### 5. What is Dependency Injection and what are different scopes in asp.net core Dependency Injection
  - AddTransient
  - AddScoped
  - AddSingleton
#### 6. What is the use of the “launchsettings.json” file and “appsettings.json” file?
#### 7. What is the “Developer Exception Page” in asp.net Core? How can we configure custom exception handling page in asp.net core?
#### 8. How to configure the logging framework in asp.net core? What is third party logging framework that supported by asp.net core?
  - serilog
  - 
#### 9. What is the use of a filter in the asp.net core application? Explain the filter types available in the asp.net core application?
#### 10. What are some custom Filters you created? How to define a Global filter in asp.net core?
#### 11. What is your understanding of Caching? How did you use Caching in your application? In-memory or Distributed caching? Give me some examples where caching is useful.
#### 12. Do you know what is model binding in asp.net core, how is it useful for developers?
#### 13. Explain what Routing is along with attribute Routing
#### 14. How did you validate your models? Any experience with FluentValidation library?

<hr>

#### MVC

#### 1. What are all the advantages of MVC?
  - flexiability
  - maintanence
#### 2. Explain various action results in MVC.
  - IActionResult 
#### 3. How do you pass data from Controller to View and from View to Controller?
  - ViewModel 
  - ViewBag
  - ViewData
  - asp tag helper
#### 4. What are Partial Views in MVC? Give me some examples where you have used them?
#### 5. Explain what ViewBag, ViewData & TempData along with examples from your project.
#### 6. What are HTML Helpers in old MVC and compare them with Tag Helpers in asp.net Core MVC?
#### 7. What is ViewModel. What is the purpose of ViewModel? Could you explain on where you have used ViewModel?
#### 8. Could you explain all the filters in MVC and tell me what are all the custom filters that you have?
#### 9. What are all the different state management techniques in asp.net(Server-side: Sessions, Caching, Database, TempData & Client-side: localStorage, cookies, sessionStorage etc.)
#### 10. How would you display grid in Razor? How did you do Server-side Pagination, and do you know about

<hr>

#### Web API
#### 1. What is the difference between SOAP and REST services? Which one do you prefer & why?
#### 2. Why did you use REST services and what framework did you use to create REST based services? What are the advantages of REST services?
#### 3. Differences between GET, POST, PUT, DELETE & PATCH.
  - Get: get data
  - post: insert data
  - put: update
  - patch: partial update
#### 4. Explain some of the best practices you take when creating REST API?
#### 5. All the HTTP Status Codes (especially 2XX, 4XX and 5XX ones)
  - 200 Ok
  - 401 not authorized
#### 6. How would you secure a Web API and what is token-based authentication in Web API? (JWT)
#### 7. Difference between JSON and XML
#### 8. How would you handle exceptions in Web API? Which framework did you use to log those exceptions?
#### 9. How did you do validation in your API, have you used any third-part validation libraries like FluentValidation?
#### 10. How did you consume your RESTful / Web API services, make HTTP Requests in C#, tool such as Postman)?
#### 11. Do you know what is Swagger or OpenAPI Specification? How did you generate documentation for your API so that clients can understand it?
#### 12. Do you know what CORS is and why is it useful and how can you apply CORS for your API?
#### 13. How to do unit testing in web api? What tools you use to test web api?

<hr>

#### 3rd party libraries
#### 1. What are your favorite 3rd party libraries in .NET?
#### 2. Have you worked with Automapper, FluentValidation etc.?
#### 3. What libraries have you used to send Emails
#### 4. What logging libraries have you used? Serilog, NLog etc.?
#### 5. Any 3rd party IOC Containers Ninject, Autofac etc.?
#### 6. Have you worked with Hangfire? Where did you use it?
#### 7. Any experience with MiniProfiler?
#### 8. Nunit, XUnit, Moq and FakeItEasy?

<hr>

#### Entity Framework/ORM/Dapper
#### 1. What is an ORM? What are the advantages of Entity Framework over ado .net ?
#### 2. Disadvantages of EF and how would you improve the performances of EF?
#### 3. What are the different approaches you can use in EF and which approach did you use & why?
#### 4. Do you have experience with any other ORMs such as Dapper?
#### 5. Explain what are main differences between Dapper and Entity Framework and which one would you prefer in what scenarios?
#### 6. Explain the steps of code first approach with migrations.
#### 7. What are DbSet and DbContext classes in Entity Framework?
#### 8. What is Fluent API in and how is it different from Data annotations ?
#### 9. What difference does .AsNoTracking() make?
#### 10. When would you use Skip() and Take() methods in Entity Framework ?
#### 11. What is the difference between lazy loading and eager loading? What is N + 1 problem. Which one did you use in your projects?
#### 12. How would you see the SQL queries generated by Entity Framework? What tools or coding would you implement?
#### 13. What will Entity Framework return IQueryable or IEnumerable?
#### 14. How do you disable lazy loading in Entity Framework and what is the use of virtual keyword?

<hr>

#### SQL
#### 1. Explain about your database design, were you involved in designing your database? What should you concern when designing database and tables?
#### 2. Can you explain about Normalization, especially 3NF and how it is helpful? Tell me scenarios where De Normalization is useful?
#### 3. When you opt stored procedure and when you opt function? Differences between them?
#### 4. Differences between truncate and delete?
#### 5. How you handling transactions? Can you explain ACID properties?
#### 6. What are the indexes and what are the advantages and advantages (explain both clustered and non-clustered)?
#### 7. Explain Primary Key, Foreign Key and Unique Key with differences?
#### 8. Triggers in SQL Server?
#### 9. Differences between table and View?
#### 10. When would you use Temp table vs Table variable?
#### 11. What are all the benefits of CTE?
#### 12. Explain something about temp table? Explain the process destruction of temp tables?
#### 13. Explain all the joins?
#### 14. What is the difference Between Union and Union all?
#### 15. What is a group by clause?
#### 16. Have used @@Error and @@Rowcount?
#### 17. How can you handle exceptions in SQL statements and Stored Procedures?
#### 18. Do you know what is execution plan and how do you analyze it ?
#### 19. Any experience with SQL Profiler and Database Tuning Advisor?
#### 20. How would you perform pagination with Stored Procedures (SQL Statements)?
#### 21. Explain all the steps for Performance Tuning of a query?
<hr>

#### Angular
#### 1. What is Single Page Application?
#### 2. What is typescript and how is it different from JavaScript?
#### 3. How do you create a two-way binding in Angular?
#### 4. Did you use commands on angular CLI or only build and deployment? Which commands you have used in angular CLI?
#### 5. What is the purpose of NgModule?
#### 6. How you pass data from a parent component to a child component and vice versa and between unrelated Components?
#### 7. Explain Angular Life cycle hooks with difference between ngOnInit and constructor.
#### 8. What is angular View encapsulation?
#### 9. What are directives, difference between structural directives and attribute directives?
#### Structural Directives
#### ● ngFor
#### ● ngIf
#### ● ngSwitch
#### Attribute Directives
#### ● ngClass
#### ● ngStyle
#### ● ngModel
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


<hr>

#### Web/HTML/CSS
#### 1. Describe the difference between a cookie, sessionStorage and localStorage.
#### 2. What are data- attributes good for?
#### 3. What is a CDN and what is the benefit of using one?
#### 4. What does a doctype do?
#### 5. Semantics in HTML?
#### 6. Tell some of the tabs you know in Chrome Developer tools and what can you do with those?
#### 7. What existing CSS frameworks have you used locally, or in production? How would you change/improve them?
#### 8. Have you used Bootstrap and why?
#### 9. Explain Bootstrap Gris system?
#### 10. Have you used CSS Grid or Flexbox?
#### 11. Tell me about your experience with responsive web design (Bootstrap)
#### 12. Explain what are media queries in CSS?
#### 13. What is the CSS display property, and can you give a few examples of its use?
#### 14. Explain CSS Box Model?
<hr>

#### Javascript
#### 1. What is your experience with JS? Have you used any JS libraries/frameworks?
#### 2. What is the diff between == and ===?
#### 3. What are the differences between variables created using let, var or const?
#### 4. Explain Promises in JS along with its use case?
#### 5. Explain Closures in JavaScript and where did you use?
#### 6. What are Prototypes in JavaScript and what is their purpose?
#### 7. Explain Callbacks in JS
#### 8. Explain hoisting in JavaScript
#### 9. What is XMLHttpRequest and how can you consume an API in plain JavaScript without any library?
#### 10. Can you offer a use case for the new arrow => function syntax? How does this new syntax differ from other functions?
#### 11. Can you describe the main difference between the Array.forEach() loop and Array.map() methods and why you would pick one versus the other?
#### 12. What’s the difference between an “attribute” and a “property”?
#### 13. What is the difference between a variable that is: null, undefined, or undeclared? How would you go about checking for any of these states?
#### 14. What is the difference between call and .apply?
#### 15. Explain the difference between synchronous and asynchronous functions
#### 16. Describe event bubbling
#### 17. What is event loop? What is the difference between call stack and task queue?
#### 18. Tell me how to make an AJAX call using jQuery.
#### 19. Explain the same-origin policy with regards to JavaScript, CORS?
#### 20. How would you handle exceptions or errors in the front end (globally)?
#### 21. What tools and techniques do you use debugging JavaScript code?

<hr>

## Application Architecture
#### Security

#### 1. Explain to me the security measures you would take for your application both Front End and Back End.
#### 2. Explain authentication and authorization mechanisms in your project.
#### 3. Any experience with oAuth ?
#### 4. Have you used any toke-based authentications such as JWT ?
#### 5. What is SQL Injection and how would you prevent SQL injection
#### 6. What is cross-site scripting, CSRF (Cross site request forgery) attacks? How would do prevent it?
#### 7. How would you prevent Cross-site scripting (XSS) attacks?
#### 8. How did you store your passwords in your DB.? (What security measures did you take to store passwords in your database?)
#### 9. When it comes to bank data, how are you securing data so, what type of encryption you were using?
#### 10. Where and how are you storing your database, connection strings or any application settings data such as API key’s etc. securely
#### 11. What mechanisms did you do to have proper Logging and Monitoring of your application, health checks etc.

<hr>

#### Architecture and Design patterns
#### 1. What is dependency injection. Advantages and Disadvantages. Your use of dependency in your project. What IOC did you use in your project?
#### 2. Explain SOLID principles.
#### 3. Explain the whole architecture of your project including your technologies you have used. (n-layer, Onion, CQRS)
#### 4. Explain microservices architecture? How is it different from Monolithic Architecture?
#### 5. What are the advantages of microservices?
#### 6. What are the challenges faced while using Microservices?
#### 7. How can independent micro-services communicate with each other?
#### 8. What is the use of Docker? How does it help in microservices?
#### 9. Please explain OOP concepts with examples from your project.
#### 10. Explain the design patterns you have used in your project
  - Dependency Injection
  - Singleton
  - Factory
  - Repository
  - Abstract Factory
  - Adapter
  - Strategy<hr>

#### Azure/Cloud/DevOps
#### 1. What is your experience with Azure, what Azure services have you used?
  - Azure Functions
  - Azure Blob storage
  - Azure App Service
  - Azure SQL
  - Azure Cognitive Services
  - Azure DevOps
  - Azure Queue
  - Azure Service Bus
#### 2. Have you used any CI/CD such as Azure DevOps, TeamCity etc. Explain your process.
#### 3. Explain all the different environments (development, QA / Testing, UAT, Production / Live)
#### 4. Can you tell me some Azure acronyms, IaaS, SaaS, PaaS and serverless?
#### 5. What is Azure blob storage, how do you utilize to your project?
#### 6. Do you have any experience with serverless architecture such as Azure Functions ?
#### 7. What is your experience in deploying the application to on premise and cloud infrastructure?
#### 8. What is your experience with Azure App Service?
#### 9. What source controls have you used in your work experience with projects? Git, TFS, SVN?
#### 10. Do you have any experience in Messaging Queues such as RabbitMQ, Azure Service Bus etc.?
<hr>

#### Performance Improvements
#### 1. Explain to me the steps that you would take to improve the performance of your application (Front end and back end)
#### 2. What is your experience with Caching? in Memory caching? Any experience with Redis?
#### 3. What tools have you used to analyze the performance of your application?
#### 4. What steps did you take to improve UI responsiveness?
<hr>

#### Testing

#### 1. What is your experience with testing? Especially, unit testing and what tools/ frameworks did you use to do unit testing, and what is your code coverage
#### 2. Have you used any mocking libraries such as Moq etc.?
#### 3. How did you do Integration testing?
#### 4. What kind of tools have you used for both Load and Stress testing your application?
#### 5. What is your experience with Postman? What did you use it for?
#### 6. What is your unit testing experience with Angular? Jasmine, Karma etc.?
#### 7. Any experience with TDD?
#### 8. What is your code coverage? What tools have you used for it?
<hr>

#### General Behavioral
#### 1. Introduce yourself and could you please explain your last project.
#### 2. If you were created a new web site today, what technology you will choose, why?
#### 3. What kind of a project management experience do you have in your projects (Waterfall and Agile)?
#### 4. Explain your Agile process & how long are your sprints?
#### 5. How is your interaction with QA & BA?
#### 6. What were your roles and responsibilities in your latest project?
#### 7. What is your experience with code review?
#### 8. How do you keep yourself updated with new technologies?
#### 9. What was the most challenging thing in your project? (Technical and non-technical)
#### 10. What are the steps you take if you have a high priority production bug (i.e., users cannot login etc.)?


  
