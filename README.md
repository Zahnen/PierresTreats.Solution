# Sous Chef
### An MVC application written in C#, January 15, 2021

#### By [Zahnen Garner](https://www.github.com/zahnen)

---  

_Sous Chef is a baker's note-taking and sharing tool, for use in recipe development/improvement. Users can log goods they've baked, links to the recipe they used, and notes that include any modifications they've made to the original recipe. Sous Chef helps bakers find their own baking style while keeping meticulous track of their favorite recipes + their notes-to-self for next time. Sous Chef offers categorizing of recipes via the Flavor Profile tab, wherein users can assign flavor profiles to their projects. This allows recipes to be sorted through by flavor specifically when a user is in the mood for a particular good. Sous Chef was created as an independent project while studying at Epicodus. The application was created to apply concepts I learned this week which include user authentication with Identity, the basics of code-first migration with EF Core & MySQL, establishing relationships within databases using join tables, using ASP.NET Core, and implementing CRUD functionality within an MVC application._  

---  

## 🔍 Demo

![GifDemo](https://i.giphy.com/media/05lxXGiFOEdM818agf/giphy.webp)

## 📘 User Stories

<details>
  <summary>Expand</summary>
  This project was created to answer to the following user stories:
  <table>
  <tr>
    <th>Scenario 1</th>
    <th></th>
  </tr>
  <tr>
    <td>Behavior</td>
    <td>The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.</td>
  </tr>
  <tr>
    <td>Completion</td>
    <td>✅</td>
  </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 2</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>There should be a many-to-many relationship between Treats and Flavors. A treat can have many flavors (such as sweet, savory, spicy, or creamy) and a flavor can have many treats. For instance, the "sweet" flavor could include chocolate croissants, cheesecake, and so on.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
  <table>
    <tr>
      <th>Scenario 3</th>
      <th></th>
    </tr>
    <tr>
      <td>Behavior</td>
      <td>A user should be able to navigate to a splash page that lists all treats and flavors. Users should be able to click on an individual treat or flavor to see all the treats/flavors that belong to it.</td>
    </tr>
    <tr>
      <td>Completion</td>
      <td>✅</td>
    </tr>
  </table>
</details>

---  

## 🔧 Setup/Installation Instructions

Running this project locally requires:
- A code editor such as [VisualStudio Code](https://code.visualstudio.com/) 
- [ASP.NET Core](https://dotnet.microsoft.com/download/dotnet-core/2.2)
- [MySQL/MySQL Workbench](https://www.mysql.com/).
- A loose familiarity with MySQL databases & navigating through local files using your command line program such as Terminal or Gitbash (e.g., "cd Desktop").

Please ensure all of the aforementioned softwares are installed on your device or refer to the previous links to begin installation. If you have questions on the installation process, please don't hesitate to [reach out!](mailto:zahnen@gmail.com)

### 1. Clone or Download the project:

#### To Clone:
- Open your preferred command line program.
- Navigate to the location or directory you'd like the project directory to be created in. (e.g., "cd Desktop" if you'd like to clone the project to your desktop)
- Enter the command "$ git clone https://github.com/zahnen/PierresTreats.Solution" in your command line.

#### To Download:
- Navigate to the [project repository](https://github.com/zahnen/PierresTreats.Solution) in your browser.
- Click the green "Code" button toward the top right of the page.
- Click "Download ZIP" and extract the files.
- Open the newly-downloaded project in your preferred code editor.


### 2. Establish a MySQL database for using the project:

#### Code-First migration with EF Core (Preferred):

- Create a file at the root level of the directory named "appsettings.json" _Note: This file is included in this repository for the purposes of submitting the project as a graded assignment. If you elect to move forward with code-first migration with EF Core, you may simply replace the contents of this file rather than create a duplicate "appsettings.json" file._
- Add the following code into the appsettings.json file

```
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[ENTERDATABASENAMEHERE];uid=[ENTERUSERIDHERE];pwd=[ENTERPASSWORDHERE]];"
    }
}

```
- Replace the [ENTERDATABASENAMEHERE], [ENTERUSERIDHERE], and [ENTERPASSWORDHERE] placeholders with your desired database name + your user information associated with your local MySQL server.
- Navigate to the directory titled "PierresTreats" within the root directory created when cloning the project.
- Run the command "dotnet ef database update" to establish the database in MySQL using the migrations included with this repository (suggested).
- If you choose to modify the database by altering the model logic of this project, save all changes and then run the command "dotnet ef migrations add [ENTERMIGRATIONNAMEHERE]" within the "PierresTreats" directory to create a new migation using EF Core. Replace [ENTERMIGRATIONNAMEHERE] with whatever you'd like to name this migration. Follow this by running the command "dotnet ef database update" to update the MySQL database with your changes. You will need to create a new migration _and_ update the MySQL database each time you modify elements of the existing database within the code.
- Verify that your newly establish database exists within your MySQL Workbench before proceeding (you may need to right click the explorer and click "Refresh All" to see the new database).

#### Importing the database using the included .sql file:

- Open MySQL Workbench and navigate to the server on which you'd like to host the database.
- In the workbench's navigation panel, click "Server" and then click "Data Import".
- Select the option to "Import from Self-Contained File" and select the file titled "zahnen_garner.sql" from within the project directory using the file navigator.
- To run the project successfully, I recommend that all schema objects be imported when prompted and that you create a new schema when importing (click "New" next to the "Default Target Schema" input and name the schema how you see fit).
- Ensure that you're proceeding with the "Dumpstructure and Data" option towards the bottom of the import screen.
- Click "Start Import"
- Verify that your newly establish database exists within your MySQL Workbench before proceeding (you may need to right click the explorer and click "Refresh All" to see the new database).


### 3. Run the project:

- Once the project is cloned and the MySQL database is established, use your preferred command line program to navigate to the directory titled "PierresTreats" within the root directory created when cloning the project.
- To run the console application, enter "dotnet build" in your command line while still within the "PierresTreats" directory. Follow this command with "dotnet run"
- Your command line will open a server (likely "http://localhost:5000/"). Navigate to this URL in your browser to view the project.

---  

## 📊 SQL Schema

![Schema diagram](https://i.imgur.com/FKCdkiO.jpg)

---  

## ❗ Known Bugs/Issues

There are no known bugs or issues at this time. If you come across any, please let me know by [emailing me](mailto:zahnen@gmail.com).

---  

## ❓ Support and Contact Details

- Zahnen Garner // zahnen@gmail.com

---  

## 💻 Technologies Used

_This application required use of the following programs/languages/libraries to create:_
- _[Microsoft Visual Studio Code](https://code.visualstudio.com/)_
- _[Git/GitHub](https://github.com/)_
- _[C#](https://docs.microsoft.com/en-us/dotnet/csharp/)_
- _[.NET Core v 2.2](https://dotnet.microsoft.com/download)_
- _[ASP.NET MVC](https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/introduction/getting-started)_
- _[ASP.NET Identity](https://docs.microsoft.com/en-us/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity)_
- _[ASP.NET Razor](https://docs.microsoft.com/en-us/aspnet/web-pages/overview/getting-started/introducing-razor-syntax-c)_
- _[EF Core](https://docs.microsoft.com/en-us/ef/core/)_
- _[MySQL/My SQL Workbench](https://www.mysql.com/)_
- _[MySQL Designer](https://ondras.zarovi.cz/sql/demo/)_
- _[Bootstrap](https://getbootstrap.com/)_
- _[CSS](https://developer.mozilla.org/en-US/docs/Learn/CSS)_

---  

## 📃  License

*Licensed under MIT*

Copyright (c) 2020 Zahnen Garner