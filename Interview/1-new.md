1. how do you implement lazy loading in angular

       In Angular, NgModules are eager loading, meaning as soon as the application loads, so do all ngModules.
       
       But for large applications, we want to do lazy loading. it gonna load ngmodules when we needed
       
       route configuration use loadChildren in appRoutingModule 
       
       Use ToList for immediate loading else Ef core will do lazy loading by default
       
2. What is angular life cycle hook

       Angular manages all components and directives when it creates it, update it, delete it.
       OnChanges: called when the input properties have changed
       OnInit: initializtion
       Detroy: before it has been destroyed
 
       we can use lifecycle hooks to tap into key events. 
       initialize new instances,  initiate change detection, response to update, clean up before deletion
      
  
3. What is observable in angular 

       provides support for delivering messages between different parts of application
       use observables to perform asyn operations, to handle asyn data
       for example, http request, perform long network request without blocking main thread

4. How do you implement JWT authorization

       Configure Authentication and JWT
              in program.cs, update library jwtbearer, IdentityModel.
              Add Configuration Code: service.addAuthentication
              Define Secret Key in appsetting.json file
       Enable HTTPS and Authentication
              app.UseHttpsRedirection();
              app.UseAuthentication();
       Add a Service
       Add a Controller
       Enable Authentication for the Sample Controller


5. Difference between cluster and non cluster index
        
        primary key by default is clutered index, only have one
        represents the physical order of the data
        
        nonclustered index stores the address of data
        
6. What is CTE and how to use it 

       common table expression: temporary named result set 
       break up complex queries
       used it for recursive query, or Substitute for a view

7. Different between inner join and left join

       returns rows when there is a match in both tables.
       LEFT JOIN: returns all rows from the left table, even if there are no matches in the right table.

8. What is micro service and explain


       micro service achitecture, seperate huge applications into multiple independent applications.
       they are communicated thru web api, they work together to finish a complete task.
       for example, e-commerce website 
       microserives run in containers which runs in a VM, which runs in a hyperviser, which runs in a server
       kubernetes to mange contianers
       
9. What is date function in sql

       accepts a date, datetime, or valid date string and returns the Day part as an integer value
       
10. What is middleware and explain 

        Middleware is software that's assembled into an app pipeline to handle requests and responses. 

11. What is route guard
       
        Angular's route guards are interfaces which can tell the router whether or not it should allow navigation to a requested route
        
12. promises vs. observables
       
        promise: returns all data at once, provides a single data, native to JS
        observables: streaming the data, sending the data in packets, library rxjs, subscribe
## 

       Authentication verifies the identity of a user or service,
       and authorization determines their access rights
       
       
       
       
## Solid principles
       Single responsibility: one class have only one job to do
       Open-closed: a class is open for extension and closed for modification
       Liskov substitution: a derived class must be substitutable for its base class.
       Interface segregation: segregate huge inteface to be simle
       dependency inversion: high-level modules/classes should not depend on low-level modules/classes

