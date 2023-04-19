## Omega
Author: Tran Ngoc Tuan

Date: 19. 2. 2023

Contact: tranngoc@spsejecna.cz

School: SPSE Jecna

#
# About
This is a project for school.

The aim of this project is to manage tasks given by your employers.

# 
# Requirements
1. windown
2. .net core 6
3. MSSQL Database Server

#
# Configuration
Import the database from the db/DbExport.sql into MSSQL database server.
In the Omega/config/App.config
fill in the database configurations
```XML
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
  <appSettings>
    <add key="DataSource" value="server"/>
    <add key="Database" value="name of the database"/>
    <add key="Name" value="username"/>
    <add key="Password" value="password"/>
  </appSettings>
</configuration>
```

#
# Controls
After the program start you need to log in.
There is a main menu on the left side
- Dashboard - all uncompleted tasks
- Projects - all projects
- Finished Tasks - all finished tasks (can be reverted)
- Employees - all employees under manager in the same team
- Settings - settings for personal information
- Log out


