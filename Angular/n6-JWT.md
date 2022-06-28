<h2 align="center">JWT </h2>

- JWT: Json Web Token
- JWT can be signed using a secret with HMAC algorithm
- or using a public/private key pair using RSA or ECDSA


<hr>
For signin

1. appsetting.json:

```
 "JWT": {
    "ValidAudiene": "User",
    "ValidIssuer": "https://localhost:7137",
    "Secret": "AntraIncBlogSecretKey1234567"
  },
```

2. program.cs

```
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{

    x.SaveToken = true;
    x.RequireHttpsMetadata = false;
    x.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidAudience = builder.Configuration["JWT:ValidAudiene"],
        ValidIssuer = builder.Configuration["JWT:ValidIssuer"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Secret"]))
    };
});

```

3. program.cs

```
app.UseAuthentication();
```


