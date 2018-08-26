Web Services
------------------------
Web service is an application for interacting directly with other applications over the internet. It is a way to develop interoperable applications over the internet.


Web Service Protocols
------------------------
SOAP - Simple Object Access Protocol
REST - Representational State Transfer

Both are web communication protocols. SOAP was the standard approach to web service interfaces for a long time, but now REST is the preferred approach.


SOAP vs REST
-------------------------

1. SOAP is an XML based protocol
   REST is an architectural style protocol

2. SOAP transfer is over HTTP and can also use protocols like TCP/UDP/SMTP
   REST transfer is only over HTTP

3. SOAP permits only XML
   REST supports many different data formats

4. SOAP runs on HTTP but envelops the message
   REST uses the HTTP headers to hold meta information


RESTful Services
------------------------
In .NET, there are two ways to create RESTful services

1. WCF service - Windows Communication Foundation - To use WCF as WCF REST service, you have to enable webHttpBindings. It supports HTTP GET and POST verbs by [WebGet] and [WebInvoke] attributes resp.

2. Web API     - It uses the full features of HTTP (like URIs, request/response headers, caching, versioning, various content formats). It also supports MVC features like routing, controllers, action results, filters etc.


WCF vs Web API
-------------------------
1. WCF requires a lot of configuration to convert it into a RESTful service
   Web API is by nature a RESTful service

2. WCF is more suited for building services that are transport/protocol independent.
   Web API is more suited for building services over HTTP protocol



MVC vs Web API
-------------------------
1. MVC can return both data and views
   Web API can only return data

2. MVC returns data in JSON format by using JSONResult
   Web API returns data in various formats such as JSON, XML, etc.

3. MVC features like routing and model binding are defined in System.Web.Mvc
   Web API features like routing and model binding are defined in System.Web.Http    

4. MVC cannot create RESTful services
   Web API is meant to create RESTful services


FAQ
--------------------------

1. What are the advantages of using REST in Web API ?
REST makes less data transfers between client and server, which makes it ideal for use in mobile apps. Web API supports HTTP protocol thereby it reintroduces the od way of HTTP verbs for communication.

2. Can we unit test Web API?
Yes, we can, using Fiddler tool. Steps: Compose Tab -> Enter Request Headers -> Enter the Request Body and execute

3. What is the difference between MVC Routing and Web API routing?
In Web API pattern, we can find "api/" at the beginning, which makes it distinct from MVC routing. Also, "action" parameter is not mandatory in Web API but it can be part of routing.

4. How can we handle errors in Web API?
Below classes can be used for error handling:
 - HttpResponseException
 - Exception filters
 - Registering Exception Filters
 - HttpError
 
5. Explain Authentication in Web API
Web API authen
