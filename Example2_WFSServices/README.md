# WFS Service using unoGIS package
This application is an example of how to build a WFS service using unoGIS package.
To be able to build a WFS service using unoGIS package we have to:
- Add a new controller (Controller de ASP.NET)
- Modify the Index view referring to the controller
- Modify the URL http:/..../WFS rewriting ?service=WFS&request=GetCapabilities at the end of the URL
- It will download a file with the layers of the examples we choose
