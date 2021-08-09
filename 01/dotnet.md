# Welcome to .NET

## What is .NET?
- .NET is an open source developer platform created by Microsoft. It's for building many different types of apps, such as web apps, desktop apps, games, api, smart phones apps....
- In short, .NET Platform is a collection of **languages**, **libraries**, and **frameworks** to make various applications, developed under one common standard.
- With .Net platform you can build your app, test app, deploy the app and maintain. This is why .Net caters mostly all phases of SDLC.

## Supported Programming Languages
- Dozens of programming languages are supported by .Net provided they are compatible with the platform. [List](https://en.wikipedia.org/wiki/List_of_CLI_languages)
- 3 different languages which are by default supported by .Net are
- C#: Object oriented, type safe language
    - object oriented means, that everything is an object. These objects are further organized with classes
    - Type-safe means that once you declare a type of a variable, you can't really change it. 
- Visual Basic : Supports UI and component oriented language.
- F#: F# is a functional programming language supported by .NET
- All .Net compliant languages ahve to follow a Standard. These standard are defined by CLS (Common Language Specification).
  - CLS gives a set of rules and regulation a .Net compliant language should follow. Ex all .Net compliant languages should be OOP languages, Array index should start from 0 etc...

## Technologies we'll be using during this training
- .NET 5 and C#
- SQL (Sql Server)
- ASP.NET Core for creating web applications
- Azure Cloud Service for hosting
- Javascript, Typescript, HTML, CSS, jQuery and Angular for frontend

## [History of .Net](https://docs.microsoft.com/en-us/dotnet/core/porting/versioning-sdk-msbuild-vs)
- Microsoft introduced .Net 1.0 (deprecated) in 2002. It was known as .Net Framework
  
## .NET Implementation
4 main implementation of .NET 
- **.NET Framework**: first implementation of .NET, only works on windows, and it is shipped with every windows.
- **.NET / .NET Core**: .NET Core is the cross-platform implemtation of .NET, and is a successor of .NET Framework. 
    - This is a primary implementation of .NET and is the focus of ongoing development effort. This what we'll be using.
    -.NET 5
- **Mono**
    - .NET runtime that power Xamarin application. 
    - useful when small footprint is needed
    - also powers games built with Unity
- **Universal Windows Platform (UWP)**
    - Used for building modern, touch-enabled Windows applications and software for the Internet of Things (IoT). 
    - It's designed to unify the different types of devices that you may want to target, including PCs, tablets, phones, and even the Xbox.

## Components of .NET Implementation
- One or more runtime: Example, .NET Framework CLR, .NET 5 CLR
     - [CLR](https://docs.microsoft.com/en-us/dotnet/standard/clr) stands for *Common Language Runtime* and it's a runtime environment provided by .NET.
     - Compilers and tools expose the common language runtime's functionality and enable you to write code that benefits from this [managed execution environment](https://docs.microsoft.com/en-us/dotnet/standard/managed-execution-process).
- A class library, for example, .NET Framework Base Class Library, or .NET 5 Base Class Library.
- Optionally, we have one or more application frameworks, such as ASP.NET Core for web application development, Windows Forms, etc.
- Optionally, development tools. Some are shared among multiple implementations.

#### CLR? SDK?
- CLR Stands for Common Language Runtime, and it's runtime environment. It is also know as main execution Engine and is used to run any .Net application.
- SDK stands for Software Development Kit.
- CLR comes included in SDK

## .NET Standard
- .NET Standard is a base set of API's that are common to all .NET implementation.

### Additional Frameworks
These are frameworks that extend .NET platform to provide additional functionalities.
- **ASP.NET Core**: Open source framework for building web apps and web services
    - it's a redesign on ASP.NET 4.x with architectural changes that result in a lener, more modular framework
- **Unity**: Real-time 3D development platform
- **UWP (Universal Windows Platform)**: for developing various windows applications
- **Xamarin**: for mobile development
- **ML.NET**: machine learning
- and more..
## Types of Applications
- CUI (Character User Interface) - command line interface. Ex console app in .Net
- GUI (with user friendly UI) - Desktop app, web apps
- Smart UIs - Android or IOS
- APIs - REST Api
- Cloud application : Azure, GCP, AWS
### Other Niceties..
- **Nuget**: a package manager for .NET

.NET 5
ASP.NET: ASP.NET Core to match with .NET Core 

## [Namespaces](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/namespaces/using-namespaces)
- They organize large code projects.
- They're delimited by using the . operator.
- The using directive obviates the requirement to specify the name of the namespace for every class.
- The global namespace is the "root" namespace: global::System will always refer to the .NET System namespace.
## C#
### [Anatomy of C# program](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/program-structure/)
- namespace -> Types -> Type members
    - Namespace
        - Types - Members (Methods, variables, properties)
- [Types](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/types) (Classes, Enums, Structs, Interface, Delegates)
  - All types in C# are inherited directly or indirectly Sytem.Object
        - **[Value Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/value-types)** - which has the direct value, stored in memory Stack, fast to access. Structs, Enums. Predefined (int, long, short, byte, DateTime, char)
        - **[Reference Types](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/reference-types)** - it stores the reference to that value, value is stored in heap, expensive retrieval process. Classes, interface, Delegates. Predefined -> string, arrays, collections etc
  - Type Conversion : conversion of 1 type into another 
    - Implicit type conversion : no need to type cast. Ex byte value can be placed in int. No data loss.
    - Explicit type conversion : type cast it using `<datatype>.Parse(value)`, `Convert.<datatype>(value)`. You can have a data loss if its not fitting in the type.
  
- **Boxing**- refers to conversion Value type to reference types.
- **Unboxing**- refers to conversion of reference types to value types.

## [Statements](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/statements-expressions-operators/statements)
- A statement can consist of a single line of code that ends in a semicolon, or a series of single-line statements in a block. A statement block is enclosed in {} brackets and can contain nested blocks.
  -  **Expressions statements**: consists of operands and operators. Ex a + b ;
  -  **Declaration statements** : creating a new variable. Ex int a;
  -  **Selection Statements** : enables to branch a code in different sections based on the conditions. Ex if, else, switch, case.
  -  **Iteration Statements** : enables to repeat or loop through. Ex do-while, for, foreach, while.
  -  **Jump statements** : transfer controlt o another section of code. Ex break, continue, default, goto, return.
  -  **Exception handling statements** : recover from runtime errors gracefully. Ex throw, try-catch, try-catch-finally, try-finally.

## [Arrays](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/) 
- A variable to hold multiple values which are of same type (homogenous) and are located in contigious memory location.
- An array which in initialized must consist of a value.

## OOP(Object-Oriented Programming)
- Procedural Oriented languages - C, C++
  - The code scattered - variables, functions were loose and no structure.
  - Data leak due to garbage, that means data is less secure.
  - What to do and How to do?
  - Resuability wasn't a great option in Procedural oriented language.
- OOP
  - In OOP the program is organized into classes and accessed via object.
  - Programmer focus on what to do over how to do.
  - **[Class](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes)**: Blueprint of user defined type which is mapped to real time entities. Ex: Pen can be created as class with attributes/properties - type (ball, ink), color (blue, black, red, green) , behavior (writing).
  - **Object**: An object is a implementation of the class. It has been allocated memory. Whenever a class is instantiated the obj comes into the picture.
    - `Pen pen1 = new Pen();`, `Pen pen2 = pen1`.
  - **Pillars of OOP**
    - [OOP](https://docs.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/oop) is structured on 4 pillars of OOP as:
      - **Encapsulation** - Wrapping up of the data (ex - methods encloses data field, class/Type encloses a method, namespace encapsulates the type) and data hiding, to provide protection from the outside world. We use Access modifiers to provide various levels of access.
      - **Abstraction** - Showing only essential features of the program instead on un-necessary details. In C#, abstraction can be achieved by **abstract** classes and **interfaces**. Through abstraction a template is provide which is generally impltemented by Team of Software Developers.
      - **Inheritance** - Is a waty to extend a type so that its properties and behaviours can be extended/branched further. Types of Inheritance:
        - Single - level: A->B
        - Multi - level: A->B->C
        - Hierarichal level A->B,C,D
        - Multiple inheritance - (A,B)->C
        - Hybrid inheritance - Combination of more than one above types of inheritance.
      - C# doesnot support multiple and hybrid inheritance.
      - **Polymorphism** - Poly - many, morphs - forms. Ability to implement inherited properties or methods in different ways across multiple abstractions. It can be static/Compile time polymorphism or dynamic/runtime  polymorphism. Ex Method Overloading is an example of compile time polymorphism, which is method with same name behaves differently based on signatures (parameters). Method Overriding is an example of runtime polymorphism, which is re-defining the method of parent class into child class. 
## [Strings](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/strings/)
- A `string` is an object of type `String` whose value is text. Internally, the text is stored as a sequential read-only collection of `Char` objects. 
- There is no *null-terminating* character at the end of a C# string; therefore a C# string can contain any number of embedded null characters `('\0')`. 
- The `Length` property of a string represents the number of `Char` objects it contains, not the number of Unicode characters. 
- To access the individual Unicode code points in a string, use the `StringInfo` object.
- String class offers many String operations that can be performed on a string - Contains, ToUpper, ToLower, Clone, CopyTo, Substring, IndexOf, Reverse, Replace, EndsWith, StartsWith, Trim.
```
// Declare without initializing.
string message1;

// Initialize to null.
string message2 = null;

// Initialize as an empty string.
// Use the Empty constant instead of the literal "".
string message3 = System.String.Empty;

// Initialize with a regular string literal.
string oldPath = "c:\\Program Files\\Microsoft Visual Studio 8.0";

// Initialize with a verbatim string literal.
string newPath = @"c:\Program Files\Microsoft Visual Studio 9.0";

// Use System.String if you prefer.
System.String greeting = "Hello World!";

// In local variables (i.e. within a method body)
// you can use implicit typing.
var temp = "I'm still a strongly-typed System.String!";

// Use a const string to prevent 'message4' from
// being used to store another string value.
const string message4 = "You can't get rid of me!";

// Use the String constructor only when creating
// a string from a char*, char[], or sbyte*. See
// System.String documentation for details.
char[] letters = { 'A', 'B', 'C' };
string alphabet = new string(letters);
```
- String objects are **immutable**: they cannot be changed after they have been created. 
  - All of the String methods and C# operators that appear to modify a string actually return the results in a new string object.
  - Use [String Builder](https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-5.0) class top perform operations on the string with better performance.
### Additional Resources
- [.NET Documentation](https://docs.microsoft.com/en-us/dotnet/core/introduction)
- [.NET Glossary](https://docs.microsoft.com/en-us/dotnet/standard/glossary)
- [Introducing .NET 5](https://devblogs.microsoft.com/dotnet/introducing-net-5/)
- [What is .NET?](https://www.codecademy.com/articles/what-is-net)
- [Learn C# in interactive way](https://docs.microsoft.com/en-us/users/dotnet/collections/yz26f8y64n7k07)
- [Learn C# from video](https://channel9.msdn.com/Series/CSharp-Fundamentals-for-Absolute-Beginners)