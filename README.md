# _Eau Claire's Salon_

#### By _**Eusebie Siebenberg**_

#### Indpendent Code Review project: Build an MVC web application to help a salon owner manage their employees (stylists) and their clients.

## Technologies Used

* _C#_
* _Entity Framework Core_
* _MySQL Workbench_
* _Razor_
* _ASP.NET Core MVC_
* _VS Code_
* _.NET6_
* _Command Line_

## Description 

Eau Claire's Salon is an application built to allow the user to add, edit, delete and save Stylists and their Clients. View a list of stylists details and clients, and view the stylists each client prefers. 

## Setup/Installation Requirements

1. Open your shell of choice (e.g., Terminal or GitBash) and run these commands in order:
2. Clone this repository by running $ `git clone https://github.com/user/examplerepo.git` (replace url with link copied from github)
3. Navigate to the root directory call `EauClairesSalon.Solution`, Create a `.gitignore` file with $ `touch .gitignore`, copy/paste this into the .gitignore file:
```
obj
bin
appsetting.json
```
3. Navigate to this project's production directory called "HairSalon" with $ `cd HairSalon`.
4. Within the production directory create a new file called `appsettings.json`.
5. Within `appsettings.json`, paste in the following code, replacing the `uid` and `pwd` values with your own username and password for MySQL:

```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=eusebie_siebenberg;uid=[user-id];pwd=[password];"
  }
}
```
6. Run these commands in your shell to install the necessary dependencies:
* $ `dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0`
* $ `dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0`

7. Within the production directory "HairSalon", run `dotnet watch run` in the command line to start the application in development mode with a watcher.

## Known Bugs 

* _No known bugs as of 05/19/2023_

## [MIT](https://opensource.org/license/mit/) License

Copyright (c) 5/19/2023, Eusebie Siebenberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

If you have any questions, comments, or concerns, please reach out to us at: siebenee@gmail.com