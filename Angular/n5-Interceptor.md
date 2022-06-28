<h2 align='center'>HTTP Interceptor</h2>

Authorization: right to access any part of the application

<hr>

Client <----> Server
http -> stateless

Token Based Authorization: JWT(JSON Web Token)
User gives username and password, we will hash the password and match with the database itself.
If user is authenticated, then JWT will be generated and sent back to client app (Angular APP).

Client will store the token in the localstorage of the browser, and every request header will read the token from localstorage and send it with the request...

if the token is available and valid, then the user is allowed to access the app.

<hr>

```
1. install package: Microsoft.AspNetCore.Identity;
2. Core->Entity->ApplicationUser class -> create prop(firstname, lastname)
3. infra->data->implemt IdentityDbContext
4. MVC->program.cs-> builder.Services.AddIdentity<ApplicationUser, IdentityRole>.().
  AddEntityFrameworkStores<CrmDbContext>().AddDefaultTokenProviders();
  
5. add-migration, update-database (several AspNetUsers tables will be created)

```



<hr>

1. Core->Contract->Repo->IAccountRepositoryAsync
2. Infra->Repo->AccountRepositoryAsync
3. builder.Services.AddScoped<IAccountRepositoryAsync, AccountRepositoryAsync>();

<hr>

1. Core->SignupModel
2. IAccountRepositoryAsync
3. AccountRepositoryAsync
4. Core->service->IAccountServiceAsync
5. AccountServiceAsync -> builder.Services.AddScoped()

  
