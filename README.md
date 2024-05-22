# TodoList

This repository contains the code for the TodoList project.

## Getting Started To Run Backend

To get started, follow these steps:

1. Clone the repository:
   
   ```
   git clone https://github.com/yusufmhmd4/epim-asp-asgmn.git
   ```

2. Navigate to the `9.2.1` directory:

    ```
    cd 9.2.1
    ```


3. Navigate to the `aspnet-core` directory:

    ```
    cd aspnet-core
    ```


4. Open the solution file `MyProject.sln` by double-clicking on it.

5. Select `web.host` as the startup project.

6. Update the connection string in `appSettings.json` according to your environment.

7. Open the NuGet Package Manager Console.

8. Select `EntityFramework` in the default project dropdown.

9. Add a migration:

    ```
    Add-Migration "Initial Migration"
    ```

10. Update the database:
     ```
     Update-Database
     ```

11. Run IIS Express or your preferred HTTP server to launch the application.

## Getting Started To Run Frontend

1.  Navigate to the `angular` directory:

     ```
      cd angular
     ```
2. Install dependencies

     ```
     npm install
     ```
3. Update dependencies

     ```
     npm update
     ```
4. Run the project

     ```
     npm start
     ```
     


