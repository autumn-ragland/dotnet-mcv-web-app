# .NET MCV Web App

Full CRUD .NET MVC application based on [this](https://youtu.be/HY7tD9IPfac) tutorial series

[Kevin Version](https://github.com/Kevin-CodeCrew/dotnet.mvc.example)

- .net CLI tools install `dotnet tool install --global dotnet-ef`

- Create  project with authentication `dotnet new mvc --auth Individual`
- launch.json file generated to run code via debug tab
- `--auth` creates simple authentication with hashing and salting, login and Register views and routes  
- if you don't have the SQLite in the csproj file it can be added with `dotnet add package Microsoft.EntityFrameworkCore.Sqlite`

- Data Annotation to generate table
    - `using System.ComponentModel.DataAnnotations;`
    - `using System.ComponentModel.DataAnnotations.Schema`

- Generate table 
    - `dotnet ef migrations add InitialCreate`
    - `dotnet ef migrations add InitialCreate --context ProductWebAppDBContext`

- View table using `Sqlite Explorer`

- Generate views and controllers for read all
    - `dotnet tool install -g dotnet-aspnet-codegenerator`
    - `dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
    - `dotnet aspnet-codegenerator controller -name ProductsController -m Product -dc ProductWebAppDbContext -outDir Controllers --useDefaultLayout --referenceScriptLibraries`

- Add DB to Start up file
```CSharp
services.AddDbContext<ProductWebAppDbContext>(options =>
                options.UseSqlite(
                    Configuration.GetConnectionString("DefaultConnection")));
```