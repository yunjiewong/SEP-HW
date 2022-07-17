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

4. How do you implement JWT 

5. Difference between cluster and non cluster index

6. What is CTE and how to use it 

7. Different between inner join and left join

8. What is micro service and explain

9. What is date function in sql

10. What is middleware and explain 

11. What is route guard
