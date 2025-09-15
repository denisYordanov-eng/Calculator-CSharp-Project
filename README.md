CSharp Calculator Project-

A simple web-based calculator built with ASP.NET MVC (Framework 4.7).  
The project demonstrates how to use models, controllers, and views to build a basic MVC application.

Features:

- Perform basic arithmetic operations:
  - Addition (+)
  - Subtraction (−)
  - Multiplication (×)
  - Division (÷) with divide-by-zero handling
- ASP.NET MVC form binding with strongly-typed model
- Bootstrap-based layout for responsive design


Project Structure

- Models/Calculator.cs  
  Defines the Calculator class with operands, operator, and result.

- Controllers/HomeController.cs  
  Handles input from the form, processes the calculation, and returns the result to the view.

- Views/Home/Index.cshtml  
  Provides the user interface for entering values, selecting an operator, and displaying the result.

  Technologies Used:

- .NET Framework 4.7
- ASP.NET MVC 5
- C#
- Razor View Engine
- Bootstrap (for styling)

  How to Run:

1. Clone the repository.
2. Open the solution in Visual Studio (2017 or later).
3. Make sure you have .NET Framework 4.7 installed.
4. Build the solution (Ctrl+Shift+B).
5. Run the project (Ctrl+F5) – it will start with IIS Express.
6. Navigate to the calculator page and start calculating.
