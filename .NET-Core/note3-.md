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
