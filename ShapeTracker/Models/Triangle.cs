// We have this file in a Models Folder because:
// 1. Its convention to separate business logic into multiple files
// It's convention to store business logic files in a directory called Models.

// In our first business Logic file which is this one, We write code to create a Triangle class
// the public keyword here is an access modifier and this makes our accessible everywhere within our application
// there are other access modifiers we will be exploring later while we build our app
// the curly braces we have on new lines, its within these curly braces that we will later add a constructor, methods and many other usefu functionalities

// As we know, .NET organizes its code into classes and namespaces
// A class is a template for creating objects of a specific type. In this way, a class groups related functionality
// into one unit(a template or blueprint) that can be used again and again to create a specific type of object.
// Analyzing the above explannation, a class is grouping related functionality into one; lets say we have an example class called string
// all strings as we know have a group of related functionality to one another, that is when we work with strings there 
// is a certain feature(a unique characteristic) that is attributed to only strings and that unique feature is the 
// Addition of double quotes("")..... Another example is the char datatype; all chars have a unique functionality(a unique feature)
// of we adding single quotes to them('').... So the single quote('') is a functionality that can be grouped to char's
// Again, a class is a template(it is a format) on how we create objects that have a specific type. And those objects could be strings,
// chars, ints, doubles, floats, e.t.c

// A namespace is a grouping of related class based on their importanced or function.

using System;

// Adding a namespace for our Business logic file
// We named our namespace here ShapeTracker.Models becaue it will hold all of the classes that contain our business logic
// You might be thinking why don't we name it ShapeTracker.BusinessLogic... Well the Models is the standard name in C# to describe "business logic"

namespace ShapeTracker.Models
{

    // Now we want to update our Triangle class to have fields and a constructor
    // First we add fields..... To explain fields, a C# field is eactly what a Javascript property is 
    // In more technical terms, a C# field is a variable of any type that is declared directly in a Class.
    // Here we declared our fields as variables of the integer datatype in our Triangle class
    public class Triangle
    {
        // Here is what a C# field looks like:
        public int Side1;
        public int Side2;
        public int Side3;
        // The 3 fields: Side1, Side2, Side3. These are meant to hold the three integer values that we'll use to determine the type of a triangle.
        // As we can also see, Side1, Side2, Side3 look like variables declared within a C# class. Well that's what a field is in C#
        // We can also describe this fields as members of the Triangle class, since they belong to the Triangle class
        // the Side2 field looks a little bit different from others and this is because we added an initial value of 4. We can give initial values to any class field we create
        // Later on, we removed the initial value we gave to our Side2
        // And lastly the keyword public is one of many access level modifiers. As modifiers, keywords like public specify level of protection this data has in our application. As public, our three fieldscan be accessed from anywhere in the application
        // As far as naming conventions, public fields should be in Pascal case, or UpperCamelCase.... We used Side1, but we can also use SideOne.


        // ADDING A CONSTRUCTOR
            // After we have added all our fields, let usnow improve our lives as developers and add a custom constructor that sets the values of the three sides when the triangle is created 
            // A constructor is a method that is called when a new instance of a class is created. Any information regarding the initial setup of new object can be included in a constructor 
            // HERE IS OUR CONSTRUCTOR

        public Triangle(int length1, int length2, int length3)
        {
            Side1 = length1;
            Side2 = length2;
            Side3 = length3;
        }
        // To create a class constructor, we simply need to define a method of the SAME NAME of the class
        // The access modifier public means this method is available anywhere in our application.

        // Our constructor can take none or multiple parameters. Each of these parameters (length1, length2, and length3) correspond to the fields a Triangle object should have(Side1, Side2, Side3). We can see within the curly braces of the constructor method that we assign each parameter as the value of a field.
        // Between the Two curly braces {} is the body of our constructor method-- any code that we want the constructor to execute. Here, we're setting the values of our three fields, but we could perform other actions as well
        // Note that the class's fields are in Pascal case while the constructor's Parameters are lowerCamelCase.Thats because they are variables
        // To use the Constructor, in our UI logic file, we create a new instance of the Trangle object and then we pass in the 3 lengths it needs in it, we can do:
        // Triangle coolTriangle = new Triangle(100, 010, 001);
        // Constructors create new instances of a class when the new keyword is used. new denotes that we are creating a new instance of this class
        
        // Now I want to start writing methods for my Triangle class
        // THe first method helps me determine whether 3 given lengths make up an isoceles or equilateral or scalene triangle
        // This method is pretty similar to the method we created in Javascript(the checkType() method)... The only difference here is that we will be using C# and its indentation to write our code instead of using JavaScript

        // Any C# class methods needs a name, a return type, Parameters, and access level modifiers(e.g public) areoptional... Don't forget; we have been adding the access level modifer: puublic to ensure our class or method is accessible anywhere in our Application
        // Now the name for our method would be CheckType() 
        // Here are a few things to note about our method:
        // public is the access lebel modifier which determines where in the application our method can be accessed
        // string is the return type of our method... NOTE: specifying the return type is a requirement of C# as a strictly-typed language. 
        // If our method is return nothing(i.e no return value) for our method, we just input void which means noht==thing. BUT WE MUST ADD SOMETHING IN OUR METHODS whether it be a void or a datatype it will be retuening for us
        // CheckType is name of our methods. In C#, methods are named with Pascal Casing(or UpperCamelCase)
        // Any parameters go between the Parens() follwing the method name
        // Between the two curly braces {} is the body of our method --- i.e any code that we want to run
        

        public string CheckType()
        {
            return "I can't answer that yet!";

        }

        // We can easily call our 



    }


}

// Things we noticed:
// 1. We can give a namespace multiple names separated by a period.. In this case, we are using two names, the name of our Project(ShapeTracker)
// And the name of a component within our project, Models, to create one namespace: ShapeTracker.Models
// A component is one aspect of our project. Our two components are user interface and business logic. Two basic groupings we can organize our code with; however we could identify components in other ways
// In Summary, with the namespace ShapeTracker.Models, we're seeing another very common convention in namespace naming: start with the name of the Project or company and then add the name of the component or feature that the namespace groups... You can read more about namespaces on the MS Docs
// Having updated this file, we get a compiler error telling us it can no longer find our Triangle class
// THis error was because we can only access Classes via their namespaces
// There is no such thing as the Triangle class alone anymore but this Triangle class now exists in our namespace for business logic(the ShapeTracker.Models)
// So to access our Triangle class, we do: ShapeTracker.Models.Triangle in our UI logic file(Program.cs)
// As we can see when we add a class to a namespace, the name of our class is updated to include the namespace
// After correcting this error and running our code, now we see that the value of testTriable(our Triangle class variable) has been updated to show both its namespaces and class name