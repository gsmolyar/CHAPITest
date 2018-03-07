# CHAPITest

a.	The program has 1 current business requirement – write “Hello World” to the console/screen. 

b.	The program should have an API that is separated from the program logic to eventually support mobile applications, web applications, 	or console applications, or windows services.
 
		G.S: API is represented by OutputWriter class instantiated via a factory class following a Factory design pattern. The functionality 			of the class is invoked in the client project directly as well as by creating another object and dynamically providing the reference 			to OutputWriter via Dependency Injection (constructor setting).

c.	The program should support future enhancements for writing to a database, console application, etc. 
		i.	Use common design patterns (inheritance, e.g.) to account for these future concerns.
 
				G.S: OutputWriter implements IOutputWriter Interface. Interfaces are arranged hierarchically. Target-specific classes inherit 						from a base class and each implement a specific interface as well as the common interface. Segregation, Dependency injection 							among other SOLID principles are adhered to. 

		ii.	Use configuration files or another industry-standard mechanism for determining where to write the information to. 
				G.S: See app.config

d.	Write unit tests to support the API.
		G.S: See CHAPIService.Tests
