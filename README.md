# Web Development With .NET

1. www - Early 1990's
1. ASP - MS, JSP - SUN
1. .NET Framework - Early 2000's - Windows only, last version 4.8
1. ASP.NET (Web Forms)
1. MVC - Model View Controller - 2007
1. ASP.NET MVC - 2008

1. 2015/16 - .NET Core (Cross platform, opensource)
1. ASP.NET Core
1. 2020 - .NET 5, 2021 - .NET 6, 2022 - .NET 7, 2023 - .NET 8, 2024 - .NET 9


## SDLC
### Environments (Physical Server and APP urls)
CollegeMonitor - https://collegemonitor.com

1. Developer - Local : Dev Environment (Localhost)
1. QA - Code changes deployed, Tst Environment (https://tst.collegemonitor.com)
1. INT - All code changes, Integration Environment (https://int.collegemonitor.com)
1. UAT - PO/TPO/BA, User Acceptance Testing (https://uat.collegemonitor.com)
1. PROD - Prodcution Environment (https://collegemonitor.com)



# CollegeMonitor Requirements

## Entities/Tables/Models
1. Session - Id, Title, Start, Duration, Details
1. Course - Id, Name, TextBook, CreditHrs
1. Student - Id, Name, Address, Email, Program, Semester

> Course has multiple classes (One to many)
> Student may enroll on multiple courses and a course can be studied by mutiple students (many to many)


## Classwork - 2024/4/29
1. On courses page, number should be 1,2,3...N
1. For each course, there should be edit and delete buttons
1. When edit is clicked, course edit page should be displayed with course data prepopulated

## Classwork - 2024/5/2
1. Add navigation menu for sessions
2. Modify "create new" as button with appropriate icon
3. Modify Edit | Details | Delete links to just have icons


## Web development
### Web UI application - ASP.NET Core razor pages
### REST API / HTTP API / HTTP Endpoints / Web API / Web Services
