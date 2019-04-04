# WMS Service using unoGIS package
This application is an example of how to build a WMS service using unoGIS package.
To be able to build a WMS service using unoGIS package we have to:
- Create a new project (Application Web ASP.NET (version: .NET Framework 4.6.2) MVC) 
- Manage the NuGet package unoGIS.Services
- Add a new controller (Controllers - Add - New element - Controller de ASP.NET)
- Modify the Index view referring to the controller
- Once compiled the application we click on the link that we put on the View
- Modify the URL http:/..../WMS rewriting ?request=GetCapabilities at the end of the URL
- It will download a file with the layers of the examples we choose
