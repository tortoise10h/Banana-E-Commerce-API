# Fruit Ecommerce Web Application API

This is a back-end part of a full project for an e-commerce fruits website in e-commerce and applications subject at my university. This project was developed follow RESTful API using .NET Core framework 3.1 and MS SQLServer, this is an API server for front-end part using Reactjs. In this project, we have all basic features of an e-commerce website like: 
* List your products
* Cart feature
* Rating product feature
* Order feature
* Payment feature using [Stripe](https://stripe.com/)
* Import product to storage management
* Export product from storage management
* ...


# How to start this project
- Install **.NET Core** SDK [here](https://dotnet.microsoft.com/download)
- Require **SQL Server** to run
- If you are using VSCode to code, so install these two plugins: **C#** & **C# Extensions**
- Run command `dotnet restore` to install all packages in csproj
- Run command `dotnet tool install --global dotnet-ef` to install dotnet ef
- Run command `dotnet watch run` to run the api server
- Run command `dotnet ef database update` every time pull new code or clone new
- Press F5 to debug (required .vscode file which is automatically recommended by Vscode)
