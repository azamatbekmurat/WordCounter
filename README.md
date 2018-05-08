# _Word Counter project with C#_

#### _C# application for counting words in a string, 04/27/2018_

#### By _**Azamat Bekmuratov**_

## Description
This web application is built with C# Asp Net Core MVC framework. The application where a user can enter a word and a text, and app finds a number of occurrences of entered word in a given text.

## Specifications

| Spec | Input | Output |
| :------------- | :------------- | :------------- |
| One Letter | Word: "a"; String: "a" | 1 |
| One Letter | Word: "a"; String: "Big apple, and red apple" | 0 |
| Input word is not alphabetic | Word: "24"; String: "Big apple, and red apple 24" | Input should be alphabetic |
| Word found one time | Word: "apple"; String: "Big apple" | 1 |
| Word found two times | Word: "apple"; String: "Big apple and red apple" | 2 |
| Word where some letters capitalized | Word: "AppLe"; String: "Big apPLe and red aPpLE" | 2 |

## Setup/Installation Requirements

* Clone this repository to your desktop.
* Navigate to the cloned directory in a terminal capable of running dotnet commands.
* Run the command >dotnet add package Microsoft.AspNetCore.StaticFiles -v 1.1.3
* Run the command >dotnet restore
* Run the command >dotnet build
* Run the command >dotnet run
* Open http://localhost:5000 link in your browser.

## Known Bugs

_No known bugs at this time_

## Support and contact details

Please feel free to contact at azaege@gmail.com with any suggestions or feedback.

## Technologies Used
* C# .Net Core MVC
* Razor
* HTML
* CSS

### License

*This software is licensed under the MIT license.*

Copyright (c) 2018 **Azamat Bekmuratov**
