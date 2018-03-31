# Service Oriented Computing and Web Services
## Velib Gateway WS
> The main idea of this project is to develop an intermediary Web Service (IWS) in C# between the Velib WS and some clients. This project has been realized by me (aka Loïc ROSE) in the school context.

## Context
The Vélib WS is a Web Service developed by a company called JCDecaux. Some cities are renting bikes and use this system. Thanks to the web service, it is possible to know what cities use the system, the list of stations and also useful information like the number of available bikes. The idea for this project is to use this API to propose a SOAP API of it.

## Available extensions

| Extension | Status   |
|-----------|----------|
| MVP       | Done     |
| GUI       | Done     |
| Async     | -        |
| Cache     | Done     |
| Deployment| -        |
| Monitoring| Done     |

## Visual Studio Solution structure
### Projet no.1: ClientConsole
This is the project for the MVP where the goal was to represents the data returned by the IWS in a console client.
### Projet no.2: ClientIWS
This is the project for the *GUI feature* but also, in a way, the *cache feature*.
### Projet no.3: MonitoringClient
This is the project for the *Monitoring feature*.
### Projet no.4: SOAPLibraryVelib
This is the project in which the services are developed (one for the vélib and the other one for the monitoring).

## Features
**1. MVP**: 
  * Development of an intermediary web service that proposes a SOAP API and that makes calls to another web service (the vélib) that propose a REST API.
  * Development of a simple console client to use the functionalities (get the list of cities or stations and the available bikes for a given station). To use the client, the first thing to do is to type the *help* command and then you can find all the commands that can b used to interect with the IWS.
  
**2. GUI**:
  * Development of a graphical interface for the client.
  * To interact with the Web Service, many buttons are there to help you. They are located on the left of your screen.
  * When you have selected a *city* and a *station* a map will appear to show you where the station is.
  * On the right side, you will have a recap' of the selected city, station and the map.
  
**3. Use of cache**:
  * Development of a system that uses a cache in order to reduce the communications between the IWS and the Velib WS. 
  * The cache is not really configurable, the only way (at the moment) is to modify the code itself. For instance if you want to modify the duration of the cache before it refreshes itself, you have to modify the following code (in SOAPLibraryVelib): 
  ``` cacheItemPolicy.AbsoluteExpiration = DateTime.Now.AddMinutes(5); ```. You can modify the number of minutes but also it is possible to modify the number of seconds or hours if you prefer.
  * *What is the impact of using a cache?* The idea is to reduce the communications between the IWS and the Vélib WS. When the IWS makes a call to the Vélib API, the result is stored in the cache for a certain amount of time and then removed. The execution time of the function will be considerably reduced by using cache. You can see that in the graphical client: every time a request is done, you can have the execution time of the function. So, when a client makes two calls in a row (for the exactly same request), the execution time will be reduced.
  * There are 2 ways to see the use of cache. The first one is to use the *IWS Client* and see the execution time for each request. The second one is to use the *Monitoring client* and see that, on the graph representing the average execution time for each function, first it's really high and then it becomes more stable (and decrease). 
  
**4. Creation of a new service for the monitoring**:
  * Development of a WS for the monitoring with a contract called *IMonitorService* and a specific client.
  * The monitoring can be done thanks to a new class called *Monitor*. In this class, there are information of the use of the IWS (number of clients connected, number of server/client requests done, average execution time for client requests).
  * In order to visualize these information, I developed another client called *MonitoringClient*. To use the client you can select the box *auto-refresh* and every 10 seconds, the charts will be updated. But if you prefer to have information manually you can click on the button *update charts* on the right of the checkbox.
