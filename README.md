# ToDoApi
Simple To-Do List app using latest .NET Web API and Angular JS.

# Download Instructions
Clone using Https, SSH or GitHub Cli, this can be done using Visual Studios.
When opening Visual Studios, under the Getting Started > Choose "Clone a repository", copy and paste the https hyperlink.
Note: to simplify executing the .NET Web API and serving the Angular JS, clone the data to a root level folder, i.e. "C:\Source"

# Updates and Maintenace (Pre-execution checklist)
- The .NET Web API uses .NET 8.0 with no dependencies other than Swashbuckle.AspNetCore (6.4.0), and this dependancy is just for a "pretty-view" of the API.
- The .NET Web API has been configured to be accessible via http://localhost:5117
(http://localhost:5117/swagger/index.html - for "pretty-view")
- The Angular JS frontend uses version 18.2.0 with no additional dependencies added.
- The Angular JS frontend uses the default http://localhost:4200 for access

# Execution Instructions
(Assuming you have cloned the repository to a root level folder, i.e. C:\Source)
  1) Run Command Prompt (Clicking Windows keyboard key > Search for "cmd")
  2) Change directory location to the base ToDoApi folder, i.e. type in the following
cd "C:\Source\ToDoApi\ToDoApi\ToDoApi"

  3a) Run the .NET Web API first, as the API needs to be running prior to the running the Angular JS, i.e. type in the following (whilst in the base "ToDoApi" folder) 
dotnet run

  3b) After keying in the command above, you should see an output indicating that the API is running, i.e.
Now listening on: http://localhost:5117

  4a) (If the above .NET Web API is running with the example output) Run the Angular JS next, by first navigating to the ToDoApp folder, i.e. type in the following
cd "C:\Source\ToDoApi\ToDoApi\ToDoApp"

  4b) Run Angular by typing in the following command
ng serve

  4c) After keying int he command above, you should see an output that the Angular development server is running, i.e.
** Angular Live Development Server is listening on http://localhost:4200

  5) Open a web browser and navigate to http://localhost:4200 to see the simple app and to use its functionality.
Note: When completing a Task, a double click on the checkbox is required, the first click updates the display and the second click updates the memory store via the .NET Web API
