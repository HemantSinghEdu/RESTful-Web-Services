WCF REST - Windows Communication Foundation
------------------------------------------
Sample WCF service creation at: https://www.youtube.com/watch?v=O6-abrmrLzI&list=PL_vG5HPso38MvDoV1zOfwtoTzkBQosHxJ
Login with edu email.
------------------------------------------

WCF REST helps us to communicate on cross platform application and exchange data in JSON or XML format with the help of GET, POST, PUT, and DELETE methods of HTTP protocol

The most commonly used HTTP methods to create WCF REST service are:
- GET : Get the resource from particular source such as SQL database
- POST:	Used to insert records into the particular source such as SQL database
- PUT : Used to modify/update the resource or records
- DELETE: Used to delete the specific resource or record from particular source


Endpoints
--------------------------

- Endpoints are a combination of ABC (Address, Bindings, and Contracts)  
- They are used to configure the communication channel between the client application and the WCF service.
- The configuration is done in the Web.config file
- The endpoints will look like below:
  
  <endpoint address ="http://localhost:4421/Service1.svc"
            binding ="basicHttpBinding"
	    contract="ServiceReference.IService1"
	    bindingConfiguration="BasicHttpBinding_IService1"
	    name = "BasicHttpBinding_IService1" />

- Address - An address is the url that defines where the WCF service is hosted. 

- Binding - Bindings are the transport protocols that are used for the communications with the client application (e.g. HTTP, Named pipes, TCP etc).
  Following are some widely used bindings:
  1. BasicHttpBinding : default WCF binding, similar to HTTP without security
  2. WebHttpBinding   : used when communicating with a client using WCF Rest
  3. WSHttpBinding    : similar to HTTPS protocol
  4. WSDualHttpBinding: supports duplex contracts and transactions
  5. WSFederationHttpBinding: Binding with federated security and transations support
  6. MsmqIntegrationBinding : used to communicate with MSMQ application along with transaction support 
  7. NetMsmqBinding   : Communication among WCF applications using queuing & transaction support
  8. NetNamedPipeBinding    : Communication among WCF applications on the same computer that support duplex contracts and transactions
  9. NetPeerTcpBinding: Communication among computers across peer-to-peer services that support duplex contracts
 10. NetTcpBinding    : Communication among WCF applications across computers, supports duplex contracts and transactions.

- Contracts : Contracts are a collection of attributes that give special meanings to the methods and classes. Contracts are a collection of the following:
  1. Service Contract 	2. Operation Contract	3. Data Contract	4. Message Contract	5. Fault Contract

  1. Service Contract	: a definition of the interface for the service. 
     Example:
	[ServiceContract]
	public interface IService1
	{
		//TODO: Add your service operations here
	}

     Service contract attribute has the following properties:
     a. CallbackContract  : Gets or sets the type of callback contract when the contract is a duplex contract.
     b. ConfigurationName : Gets or sets the name used to locate the service in an application configuration file
     c. HasProtectionLevel: Indicates whether the member has a protection level assigned.
     d. Name : Gets or sets the name for the <portType> element in the Web Services Description Language
     e. Namespace  : Gets or sets the namespace of the <portType> element in the Web Services Description Language.
     f. ProtectionLevel : Specifies whether the binding for the contract must support the value of the ProtectionLevel property
     g. SessionMode : Gets or sets whether sessions are allowed, not allowed or required.
     h. TypeId: when implemented in a derived class, gets a unique identifier for this attribute

  2. Operation Contract : defines the method that is exposed to the client to exchange the information between the client and the server. This contract describes what functionality is to be given to the client, such as addition, subtraction, and so on. The methods that are marked with the Operation contract attribute are termed as Operation contract. 
     Example: 
     [OperationContract]
     string GetData(int value);

  3. Data Contract: It is similar to get and set properties of a class. It defines how data types are serialized and deserialized. 
     Example:
     [DataContract]
     public class Student
     {
	private string name;
	private string city;

	[DataMember]
	public string Name
	{
		get{ return name; }
		set{ name = value;}
	}
     }
	

  4. Message Contract: provides an alternate way of creating and formatting SOAP messages. By default WCF communicates with a client application using a SOAP message format but we can create a custom message format using the Message contract attribute.
     Example:
     [MessageContract]
     public class Employee
     {
	[MessageHeader]
	public string Name;
	[MessageBodyMember]
	public decimal Salary;
     }

  5. Fault Contract: used to handle the exception and know the cause of the error that occurred in the WCF service. By default, when we throw an exception from a service, it will not reach the client side due to the lack of interoperability. So WCF provides the option to handle and convey the error message to the client from the service using a SOAP Fault contract.
     Example:
     [ServiceContract]
     public interface IGetDetailsService
     {
	[OperationContract]
	[FaultContract(typeof(Student))]
	Student GetDetails(string Name);
     }

     [DataContract]
     public class Student
     {
	private string name;
	private string city;
	
	[DataMember]
	public string Name
	{
		get{return name;}
		set{name = value;}
	}
	
	[DataMember]
	public string City
	{
		get{return city;}
		set{city = value;}
	}
     }
