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


