
<h2 align="center"> MVC </h2>

#### 1. What are all the advantages of MVC?
- divide the application Model, Control and View
- flexiability
- easy maintanence
- default template
  
  
  
#### 2. Explain various action results in MVC.

- view result
- partial view result
- Redirect Result
- Redirect To Action Result
- Redirect To Route Result
- Json Result
- File Result
- Content Result

```
public ViewResult About()  
       {  
            ViewBag.Message = "Your application description page.";  
            return View();  
  
       }  
```

#### 3. How do you pass data from Controller to View and from View to Controller?
  - ViewModel 
  - ViewBag
  - ViewData
  - asp tag helper
  
#### 4. What are Partial Views in MVC? Give me some examples where you have used them?
- Partial view is only a portion of page or a small markup which don't have master page


#### 5. Explain what ViewBag, ViewData & TempData along with examples from your project.

- TempData: transfer data from view to controller, controller to view, or from one action method to another action method of the same or a different controller.

```
 TempData["name"] = "Bill";
 
 if(TempData.ContainsKey("name"))
            name = TempData["name"].ToString();
            
```

```
ViewBag.Title = “Welcome”; 
ViewData[”Title”] = “Welcome”;  

cshtml:
@ViewBag.Title
@ViewData[”Title”]
```


#### 6. What are HTML Helpers in old MVC and compare them with Tag Helpers in asp.net Core MVC?
- Tag Helpers are attached to HTML elements inside your Razor views and can help you write markup that is both cleaner and easier to read than the traditional HTML Helpers. HTML Helpers, on the other hand, are invoked as methods that are mixed with HTML inside your Razor views.

#### 7. What is ViewModel. What is the purpose of ViewModel? Could you explain on where you have used ViewModel?
- viewModel: two way binding


#### 8. Could you explain all the filters in MVC and tell me what are all the custom filters that you have?


#### 9. What are all the different state management techniques in asp.net(Server-side: Sessions, Caching, Database, TempData & Client-side: localStorage, cookies, sessionStorage etc.)
- client-side 
    - view state
    - cookies: a text file that is stored on the hard drive of a client machine
    - control state
    - query string
    - hidden field
 - server-side
    - session
    - application
    - cache

#### 10. How would you display grid in Razor? How did you do Server-side Pagination, and do you know about
