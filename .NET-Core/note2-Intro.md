<h2 align="center"> Intro to .NET Core <h2>
  
## 1. Fundamentals:
- Program.cs: contains startup code
- Dependency Injection: design applications by a loosely coupled manner
- Middleware: a software assembled into an app pipeline to handle requests and responses
    - incoming requests and outcoming response
    - build-in middleware: authentication, authorization, CORS, developerExceptionPage, MVC, endpoint routing, static files
- Request Processing:
    - application code -> httpContext -> kestrel -> Http -> proxy server -> http -> Internet
    - httpContext: storage for a single request (property of request, request-specific services, data loaded, error
- Configuration: a set of external parameters provided for the application to control the application behavior
    - appsetting.JSON,or XML file
  
  
## 2. MVC model-view-controller architectural pattern
 - Routing: matching incoming HTTP requests and dispatching those requests to the app's executable endpoints
 - Convention-based routing: globally define the URL formats that application accepts and how each of those formats maps to a specific action method on a given controller.
      - routes.MapRoute(name: "Default", template: "{controller=Home}/{action=Index}/{id?}");
 - Attribute routing: specify routing information by decorating controllers and actions with attributes that define application's routes
      - [Route("api/[controller]")]  ... [HttpGet("{id}")]
 - Model Binding: convert client request data (form values, route data, query string parameters, HTTP headers) into objects that the controller can handle


    
## 3. View 
  - view helper method: controllers call view helper methods
      - An explicit view to return: return View("Orders");
      - A model to pass to the view: return View(Orders);
      - Both a view and a model: return View("Orders", Orders);
  - several ways to pass data from controller to views
      - strongly Typed mode data: ViewModel (Recommended)
          - in Controller: 
          ```
             var viewModel = new Address() {Name: ....}
             return  View(viewModel);
          ```
          - in View:
          ```
              @model WebApplication.ViewModels.Address
              <h1> @Model.Name
          ```
           - viewmodel classes either store in Models folder or a seperate ViewModel folder at the root of the app
           ```
               namespace WebApplication.ViewModels{
                    public class Address{
                        public string Name {get; set;}
           ```
                
## 3. weak Typed data
- weak Typed data: ViewData, ViewBag
    - weak Typed: don't explicitly declare data type 
    - ViewData: a ViewDataDictionary object
         - ViewData["Message"] = "Your application description page.";
         - @ViewData["Message"]
    - ViewBag: a dynamic type and skips compile-time checking
         - ViewBag.TotalStudents = studentList.Count();
         - @ViewBag.TotalStudents
                
## 4.Tag Helper
- enable server-side code to participate in creating and rendering HTML elements in Razor files
    - asp-controller: generate URL
    - asp-action: 
    - asp-route
    - 
  ```
  <label asp-for="Movie.Title"></label>
  ```
  generate a title 
                

                
                
                
                
                
    
  
