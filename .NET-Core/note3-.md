<h2 align='center'></h2>

## 1. Dependency Injection
- easier to test and maintain
- avoid code dependency; use constructor parameter
```
 private readonly IMovieService _movieService;
    public MoviesController(IMovieService movieService)
    {
        _movieService = movieService;
    }
```
- Add the configuration class to services collection in Program.cs 
```
builder.Services.AddTransient<IMovieService, MovieService>();
builder.Services.AddTransient<IMovieRepository, MovieRepository>();
```

## 2.Service Lifetimes

- Transient 
  - once they are requested from the servece container
  - best for lightweight and stateless services
  - AddTransient
- Scoped
  - once per client request (Connection)
  - AddScoped
- Singleton
  - first time requested
  - AddSingleton

## 3.achitecture
- Monolithic: entirely self-contained
- Clean architecture layers: Core - Infrastructure - User Interface - Test
- Application Core: hold business model 
  - Entities (business model classes)
  - Interfaces (for repositories and Services)
  - Domain Services
  - Custom Exceptions and Guard Clauses
- Infrastructure: data access implementations, reference to Core
  - EF Core types (DbContext, Migration)
  - Data access implementation types (Repositories)
  - Infrastructure-specific services   
- UI/API layer:
  - Controllers
  - Custom filters 
  - Custom middleware
  - Views, Partial Views & View Components
  - Program.cs


## 4. 
- [HttpGet]
- [HttpPost]


## 5. tag helper- help transfer data between view and controller bidirectinal
- instll NuGet package: Microsoft.AspNetCore.Mvc.TagHelpers
- _viewimport.cshtml in folder Views/Shared
  - @addTagHelper *, Microsoft.AspNetCore.Mvc.TagHelpers
- @model Product 
 
 
## 6. Provides attribute classes
- using System.ComponentModel.DataAnnotations;
```
[Required(ErrorMessage ="Name is required")]
public string Name { get; set; } 
```
- <span asp-validation-for="Name" class="text-danger"></span>
```
if (ModelState.IsValid)
  return RedirectToAction("Index");
```
- create multiple url based on database
  - <a asp-controller="Product" asp-action="Edit" asp-route-id="@p.Id" >Edit</a>


## 7. 
```
public class CrmDbContext: DbContext
    {
       public CrmDbContext(DbContextOptions<CrmDbContext> option):base(option)
       {}
       public DbSet<Vendor> Vendor { get; set; }
     }
```
- install  Microsoft.EntityFrameworkCore.Design,SqlServer,Tools
- program.cs
```
builder.Services.AddSqlServer<CrmDbContext>(builder.Configuration.GetConnectionString("OnlineCRM"));
```
- package manager console
```
add-migration
update-database
```

## 8.specify datatype and size 
```
using System.ComponentModel.DataAnnotations.Schema;
[Required, Column(TypeName = "varchar")]
[MaxLength(20)]
public string Name { get; set; }
```

## 9.how do you use interface/inheritance in your project?
- create IRepository interface and implement it to different repository classes

## 10. Asynchronous programming
- Task is a way for writing Asynchronous code
```
int Insert(T entity)
Task<int> InsertAsync(T entity);  //return type: int
Task InsertAsync(T entity);    //return type: void
```
- when you call asyn method, always use async and await
```
   public async Task<int> DeleteAsync(int id)
        {
          var result =  await db.Set<T>().FindAsync(id);// where(x=>x.Id==id).FirstOrDefault()
            db.Set<T>().Remove(result);
           return await db.SaveChangesAsync();  //commit
        }
```
- async methods:
  - AddAsync(entity)
  - SaveChangsAsync()
  - FindAsync(id)
  - ToListAsync()  

## 11. thread vs. task
- task will always run parallel but thread will do time sling
- one task will never block other task
- one thread will block other thead
- task is faster

## 
