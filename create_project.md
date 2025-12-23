## Summary of steps for VS Code

Follow these steps to create a solution and projects using VS Code:

Step|Description|Command
---|---|---
**1**|Create a folder for the solution.|`mkdir <solution_folder_name>`
**2**|Change to the folder.|`cd <solution_folder_name>`
**3**|Create a solution file in the folder.|`dotnet new sln`
**4**|Create a folder and project using template.|`dotnet new console -o HelloCS`
**5**|Add the folder and its project to the solution.|`dotnet sln add HelloCS`
**6**|Repeat steps 4 and 5 to create and add any other projects.|
**7**|Open the current folder path (`.`) containing the solution using VS Code.|`code .`

A **Console App** / `console` project is just one type of project template. In this book, you will also create projects using the following project templates, as shown in *Table 1.6*:

**Visual Studio**|dotnet new|**Rider – Type**
---|---|---
Console App|`console`|Console Application
Class Library|`classlib`|Class Library
xUnit Test Project|`xunit`|Unit Test Project – xUnit
ASP.NET Core Empty|`web`|ASP.NET Core Web Application – Empty
Blazor Web App|`blazor`|ASP.NET Core Web Application – Blazor Web App
ASP.NET Core Web API|`webapi`|ASP.NET Core Web Application – Web API
ASP.NET Core Web API (native AOT)|`webapiaot`|ASP.NET Core Web Application – Web API (native AOT)
*Table 1.6: Project template names for various code editors