Web API - A RESTful Service generator
------------------------------------------
Sample Web API service creation at: https://www.youtube.com/watch?v=qEj22srd3TE&list=PL_vG5HPso38NJ24bARrgW4f-umqnaQFJf
Login with edu email.
------------------------------------------

Web API is used to create REST services that run over HTTP protocol.


Routing
------------------------------------------
Routing in Web API has the following default uri defined in WebApiConfig.cs

        api/{controller}/{id}

Two things:
1. uri has "api". This is to differentiate it from MVC routes
2. The action (function) is not part of the route. Then how does Web API determine which function to invoke in the controller?

Uri is resolved in Web API by:
1. Function name: function names starting with Get will serve GET requests, while those starting with Post will serve POST requests
2. Http verbs: functions having [HttpGet] verb will serve GET requests, while those starting with [HttpPost] will serve POST requests

Any conflict arising out of having multiple functions with same starting name or Http verbs, will be resolved by the function's input parameters (their count and data types). If no resolution is possible, then the Web Api throws an error.

For example:
If there are multiple functions whose name starts with Get, each function must have a different set of parameters
     e.g. GetProducts(), GetProduct(int id), GetProduct(int id, string categ)
If there are two functions, one whose name starts with Get, and another that has the [HttpGet] verb, then the input parameter set will help in resolving the route. If both functions have the same input parameters, then an error will be thrown.
