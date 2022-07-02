<h2 align= "center"> Web API</h2>

#### 1. What is the difference between SOAP and REST services? Which one do you prefer & why?

- SOAP (Simple Object Access Protocol) is a standards-based web services access protocol

- REST (Representational State Transfer) It seeks to fix the problems with SOAP and provide a simpler method of accessing web services. 

<hr/>

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
- JWT:Json Web token is an open standard used to share security information between two parties — a client and a server.


#### 7. Difference between JSON and XML
- JSON (JavaScript Object Notation) is a lightweight data-interchange format 
- XML (Extensible markup language) was designed to carry data, not to display data

#### 8. How would you handle exceptions in Web API? Which framework did you use to log those exceptions:
- serilog


#### 9. How did you do validation in your API, have you used any third-part validation libraries like FluentValidation?
- data anotation


#### 10. How did you consume your RESTful / Web API services, make HTTP Requests in C#, tool such as Postman)?
- Postman


#### 11. Do you know what is Swagger or OpenAPI Specification? How did you generate documentation for your API so that clients can understand it?


#### 12. Do you know what CORS is and why is it useful and how can you apply CORS for your API?
- Cross origin resource sharing
- a browser security feature that restricts cross-origin HTTP requests 


        builder.Services.AddCors(options =>
        {
            options.AddDefaultPolicy(builder =>
            {
                builder.WithOrigins("http://localhost:4200").AllowAnyHeader().AllowAnyMethod();
            });
        });

#### 13. How to do unit testing in web api? What tools you use to test web api?
- NUnit


