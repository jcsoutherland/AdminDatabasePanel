# AdminDatabasePanel

Important Note: Must change sql server host string in Helper.cs to local sql server to work on any local pc sql server!

File Structure:
 >C# -> DatabaseFinal -> DatabaseFinal.sln: Is our C# code submission which interacts with our SQL Server.
  >>
  >>Table, Theater, Movies, Showing, Staff, Tickets: Table objects used for storing results from server
  >>
  >>Dashboard, CustomQForm, DeleteForm, InserForm, SearchForm, UpdateForm: Windows Forms for each function
  >>
  >>Helper, DataAccess: Classes that access the SQL server and get data
 >
 >FinalDatabaseDesign.pdf: Database design diagram
 >
 >Data.sql: The SQL query which creates our database and populate it on our server
 >
  >>Database Name: MovieTheaters, Consists of tables: Theater, Movies, Showing, Staff, Tickets
 >
 >Radom Data: Folder consisting of random data we used while creating the database
 >
 >Procedures.sql: SQL file consisting of all our SQL queries
