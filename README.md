## Triangle Checker
#### *Epicodus Practice Lesson #  (Week 1 of C#)  2/23/2021*
***By Daniel Adeyemi and Dani Renner***
___
### This project is not in a complete or portfolio ready state, and should not be considered as representation of professional work.
___
## *Description*:    
### *This app will take 3 sides and check what kind of triangle is possible (if any).*


## *Setup/Installation instructions:*
#### From the web:
* Go to my GitHub repository, using following [URL](https://github.com/DanielAdeyemi/Epicodus_2_22_LeapYear.git).
* Click the "Code" ![img](img/code.png) and click the 'Download zip' option ![img](img/zip.png).
* Unzip the file, navigate to the `Models` directory to check code or to the `ModelTests` directory to see tests.
#### From the terminal: 
* Clone my repository from GitHub using `git clone https://github.com/DanielAdeyemi/Epicodus_2_22_LeapYear.git` in your terminal or GitBash
* Navigate to the downloaded folder using ***cd*** command
* Execute **code .** command in your terminal and it will open all source code in your code editor.    
*Note: To run this project locally you will need to have .NET Core. You can check if you have .NET Core by running dotnet --version in the command line. If you do not have .NET Core please find more information and download [here](https://dotnet.microsoft.com/download/dotnet)*
### Specs:
* validate if numbers more than 0: *Assert.AreEqual(valid, testTriangle.ValidateTriangle(3,4,5))*    
*Assert.AreEqual(invalid, testTriangle.ValidateTriangle(3,-4,0))*
* validate if sides can make a triangle: *Assert.AreEqual(valid, testTriangle.ValidateTriangle(3,4,5))*    
*Assert.AreEqual(invalid, testTriangle.ValidateTriangle(2,2,8))*
* if all sides are equal display Equilateral Triangle: *Assert.AreEqual(Equilateral Triangle, testTriangle.ValidateTriangle(4,4,4))*    
*Assert.AreEqual(valid, testTriangle.ValidateTriangle(3,4,5))*
* if just 2 sides are equal display Isoscales Triangle: *Assert.AreEqual(Isoscales Triangle, testTriangle.ValidateTriangle(4,4,5))*    
*Assert.AreEqual(valid, testTriangle.ValidateTriangle(3,4,5))*
* if no sides are equal display Scalene Triangle: *Assert.AreEqual(Scaleline Triangle, testTriangle.ValidateTriangle(3,4,5))*



#### Running Tests:
* To run MS tests you will need to navigate to the `Calendar.Tests` folder *(cd Calendar.Tests)* in the command line and then run `dotnet restore`.
* You should now see **'obj'** folders in both the `Calendar.Tests` folder and `Calendar` folder.
* At this point you should be able to successfully run `dotnet test` in the command line (keep in mind you should still be in the Calendar.Tests folder).

#### View website:
*GitHub page or terminal inteructions are unavailable for this project.*

## *Tecnologies used:*
* C# v.
* .NET Core v5.0
* MSTest
* REPL
* Git and GitHub

## *Known bugs:*
This project has no execution in terminal and was used to practice TDD in C# with MSTest.

## *License and copyright:*

> ***© Daniel Adeyemi, Dani Renner, 2021***  
> *Licensed under [MIT license](https://mit-license.org/)*