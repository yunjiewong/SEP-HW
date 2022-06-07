<h2 align='center'>Day 1</h2>

#### 1. interface and upcasting
    interface Istudent{
      IEnumerable<String> GetName();
    }

    public class Student:IStudent{
      Student(){}
      public IEnumerable<String> GetName(){
        //write some code
      }
      public void PrintMessage(){
        //...
      }
    }

    public class Program{
      public static void Main(){
        IStudent s = new Student();
        s.GetName();
        //s.PrintMessage(); not valid
      }
    }
    
    
 #### 2. client-server architecture
 - client: request data
 - server: send response
 - 1-tier achitecture: UI environment, data logic,  marketing logic are on the same system
     - it has different layer
 - 2-tier achitecture: the UI stored at the client machine, and the database stored on a server 
     - server and client in direct incorporation: online ticket reservations application 
 - 3-tier achitecture: presentation layer(client)-> application layer(middleware) -> database layer
 - advantages: 
     - Cost-efficient
     - Client/Servers changed separately
     - Centralized system with data  
 - disadvantages:
     - DoS attack
     - Clients are prone to viruses, worms, and Trojans 
     - Data packets will be modified or spoofed during the transmission
   
   
   #### 3.  HTTP protocol
   - HTTP: hypertext transfer protocol: the set of rules for transferring files 
   - HTTP request
        - request method: GET (select), POST (insert), PUT (update), DELETE, PATCH (partial update)
        -  TRACE, HEAD, CONNECT, OPTIONS
   - HTTP response
        - status code: 200 OK, 300 move permanently, 401 unauthorized, 403 forbidden, 404 not found, 500 internal server error
   - proxies:
      - there is one or more proxies for each client-server interaction
      - Proxies may be transparent or non-transparent. Transparent proxies do not modify the client's request
      - purposes:
        - caching, authentication(access), logging(historical data), web filtering, load balancing(client handled by multiple servers)

#### 4.  
   - https://localhost:portNumber/ControllerName/ActionName/{Parameters}
   -   
         //Controller
         public class Customer{
            //action method
            public IActionResult Get(Id){
            }
          }
          
#### 5. achitectural pattern
   - architectural pattern: no code involved, only structure, eg. MVC
   - design pattern: write code using OOP concepts
      - singleton, repository, factory design patterns ...
   - MVC model-view-controller pattern
        - user (use)-> controller -> (manipulate) model -> (update) view (show users)
        - model: property classes
        - view: html code
        - controller: logic  

#### 6. 
- console app: execute exe files, install to use
- web application: deployed/host on web servers 
  - IIS: only in MS, Kestrel: cross platform for .NET CORE
  - kestrel: .net app will start as console app then converted to web application
  
#### 7.
- http request -> request pipeline(one or more middlewares) -> http response
- diff btw app.use and app.run
     - use will call the next middleware bc it has next delegate
     - run cannot call the next middleware, it creates terminal middleware
