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
// We named our namespace here ShapeTracker.Models because it will hold all of the classes that are in our business logic
// You might be thinking why don't we name it ShapeTracker.BusinessLogic... Well the Models is the standard name in C# to describe "business logic"

using System.Collections.Generic;
namespace ShapeTracker.Models
{

    // Now we want to update our Triangle class to have fields and a constructor
    // First we add fields..... To explain fields, a C# field is eactly what a Javascript property is 
    // In more technical terms, a C# field is a variable of any type that is declared directly in a Class.
    // Here we declared our fields as variables of the integer datatype in our Triangle class

    // As you can see, the Triangle is a class; inside of it we have fields and we set the access level(public) for our fields.... Again, the publi access level modifier just ensures our class(Triangle) can be accessed anywhere in our application
    public class Triangle
    {
        // Here is what a C# field looks like:

        // We want to update our code to work with C# properties; and a C# property is a shortcut to writing getter and setter methods and its also a mechanism that we can add to our classes to read, write and compute the value of class fields.. By "mechanism" we really mean that properties are a special type of public method that allows us to access class fields... And you should note that properties do NOT look like methods and they have special syntax
        // Having defined C# properties, you might be thinking: if properties are special methods that allows us to access our class's fields, why do we need them since we already have our gettter and setter method that do just that... Well the short answer to that question is that properties are a synthatic shortcut to creating public getter and setter methods

        private int _side1;
        // Here is the beginning of the new code we added for properties
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }
        // Here is the ending section of the new code we added for properties

        // above, we have introduced our self to c# properties; but in C# there is also a term called: auto-implemented Properties and this is an ever 
        // shorter shortcut to what we did above for side1; above we did it in 2 lines, Now we want to be able to 1. create a private field, 2. create a public property, and 3 create get and set actions(methods) to access those private fields we have just created.... 
        // all in one line of code which is this:

        public int Side2 { get; set; } // the new Side2 auto-implemented property
        // The major difference between what I did in Side1 and here is that: in Side1; this line of code(private int _side2;) is not needed because I did not later make use of the private field _side2 but in the previous one I did above; I used both Side1 and _side1 but here I am doing everyhting in a single line of code and I am using only Side2 and not Side2 with private field(_side2)
        // Since I am doing everything with Side2, then I can update my CheckType() method reference only Side2

        // private int _side2;
        private int _side3;
        public int Side3
        {
            get { return _side3; }
            set { _side3 = value; }
        }
        // The 3 fields: Side1, Side2, Side3. These are meant to hold the three integer values that we'll use to determine the type of a triangle.
        // As we can also see, Side1, Side2, Side3 look like variables declared within a C# class. Well that's what a field is in C#
        // We can also describe this fields as members of the Triangle class, since they belong to the Triangle class
        // the Side2 field looks a little bit different from others and this is because we added an initial value of 4. We can give initial values to any class field we create
        // Later on, we removed the initial value we gave to our Side2
        // And lastly the keyword public is one of many access level modifiers. As modifiers, keywords like public specify level of protection this data has in our application. As public, our three fieldscan be accessed from anywhere in the application
        // As far as naming conventions, public fields should be in Pascal case, or UpperCamelCase.... We used Side1, but we can also use SideOne.


        // when we create a static field or method for a class, I should contain data or perform functionality that's relevant to the entire class
        // Since we want to create instances of the Triangle class, we'll want to create a field or method that's relevant to the entire class
        // Having said all of the above, lets create a new folder called _instances that will hold a list of all Triangle objects ever created, 
        // and add two methods that will allow us to access and clear the list
        // to create a static, we simply need the static keyword. below is how we'll create our _instances field
        // we declare our _instances field as private and we give it a type of List<Triangle>(a list of triangle objects)
        // then with our =(assignment operator) we give our _instancesan initial value of an empty listof triangle objects
        private static List<Triangle> _instances = new List<Triangle>();


        // ADDING A CONSTRUCTOR
        // After we have added all our fields, let us now improve our lives as developers and add a custom constructor that sets the values of the three sides when the triangle is created 
        // A constructor is a method that is called when a new instance of a class is created. Any information regarding the initial setup of new object can be included in a constructor 
        // HERE IS OUR CONSTRUCTOR
        // I later updated my constructor to use to add new objectsdirctly to our static list... We can use the keyword "this" within our constructor to reference th eobject instance that i sbeing created

        public Triangle(int length1, int length2, int length3)
        {
            _side1 = length1;
            Side2 = length2;
            Side3 = length3;
            _instances.Add(this); //after making use of the built-in .Add() method, we pass "this" into it ---> and "this" is the special keyword that represents the object instance(example) being created
        }
        // To create a class constructor, we simply need to define a method of the SAME NAME of the class
        // The access modifier public means this method is available anywhere in our application.

        // Our constructor can take none or multiple parameters. Each of these parameters (length1, length2, and length3) correspond to the fields a Triangle object should have(Side1, Side2, Side3). We can see within the curly braces of the constructor method that we assign each parameter as the value of a field.
        // Between the Two curly braces {} is the body of our constructor method-- any code that we want the constructor to execute. Here, we're setting the values of our three fields, but we could perform other actions as well
        // Note that the class's fields are in Pascal case while the constructor's Parameters are lowerCamelCase.Thats because they are variables
        // To use the Constructor, in our UI logic file, we create a new instance of the Trangle object and then we pass in the 3 lengths it needs in it, we can do:
        // Triangle coolTriangle = new Triangle(100, 010, 001); --> here we practicalized hpw we could use our Triangle constructor to create a new instance of the Triangle object... And a triangle object must always and should always contain 3 paramters for 3 sides because thats what I told my constructor to take in before it creates a Trianlg object 
        // Constructors create new instances of a class when the new keyword is used. new denotes that we are creating a new instance of this class

        // Now I want to start writing methods for my Triangle class
        // THe first method helps me determine whether 3 given lengths make up an isoceles or equilateral or scalene triangle
        // This method is pretty similar to the method we created in Javascript(the checkType() method)... The only difference here is that we will be using C# and its indentation to write our code instead of using JavaScript

        // Any C# class methods needs a name, a return type, Parameters, and access level modifiers(e.g public) are optional... Don't forget; we have been adding the access level modifer: puublic to ensure our class or method is accessible anywhere in our Application
        // Now the name for our method would be CheckType() 
        // Here are a few things to note about our method:
        // public is the access lebel modifier which determines where in the application our method can be accessed
        // string is the return type of our method... NOTE: specifying the return type is a requirement of C# as a strictly-typed language. 
        // If our method is return nothing(i.e no return value) for our method, we just input void which means noht==thing. BUT WE MUST ADD SOMETHING IN OUR METHODS whether it be a void or a datatype it will be retuening for us
        // CheckType is name of our methods. In C#, methods are named with Pascal Casing(or UpperCamelCase)
        // Any parameters go between the Parens() follwing the method name
        // Between the two curly braces {} is the body of our method --- i.e any code that we want to run


        // for the getter methods
        // public int GetSide1(){
        //     return _side1;
        // }


        // commenting this one out because I have written my getter and setter for Side2 all in one line by making use of the auto-implemented property(public int Side2{ get; set; })
        // public int GetSide2(){
        //     return _side2;
        // }

        // public int GetSide3(){
        //     return _side3;
        // }

        // for the setter methods
        // Although, our simple triangle functionality doesn't really need the ability to change the value of a side(what the Setter() method does for us) but we'll add it in to practice with getter methods
        // In each of our setter methods 
        // we return nothing i.e we list our set method return type as void
        // we follow a specific naming convention: Set + NameOfField in Pascal case(e.g IamPascalCase)
        // we include a parameter for the new value that we want to assign to the field
        // we perform the assignment within the body of the method
        // Take note that we could update these methods(Setter() methods) to do more actions than just assign the value of the parameter to the field. For example, we could check if parameter value meets certain requirements before assigning it as the value of our field. In this way, we have control over how the data for each field is set
        // Finally, remember that we don't need to create a setter method if we don't need it. In other words, only create a setter method if you need to set the value of the private field outside of the class it belongs to
        // public void SetSide1(int newSide)
        // {
        //     _side1 = newSide;
        // }

        // I don't need this setter also because I have written bith my getter and setter for Side2 all in one line by making use of the auto-implemented property(public int Side2{ get; set; })

        // public void SetSide2(int newSide)
        // {
        //     _side2 = newSide;
        // }

        // public void SetSide3(int newSide)
        // {
        //     _side3 = newSide;
        // }

        // 2 new public and staic methods with oe serving as a getter and the other one serves as a setter 
        // dont' forget; this 2 getter and setter public-static methods are tools for accessing and managing the list(_instances and this is a list of triangle objects) outside of our classes
        // so the class List<T> needs to be added within them
        // Here is the first one; the getter
        public static List<Triangle> GetAll()
        {
            return _instances;
            // the 2 slight-difference between this getter for our Lists and the other getters we have written in the past is that: 1. we included the static keyword to make this a static method called on the class and we didn't follow the getter Naming convention of: Get+ FieldName in Pascal case
            // If we had follwed the getter naming convention we would have: GetInstances(because instances is our FieldName)... but using GetAll() is totally fine as long as you can understand your code 
            // and remember; a getter helps us get something(in this case our list of triangle object(_instances)).... that is why we are using the "return" built-in keyword 
        }


        // Next is to create the static setter method which we will be naming Triangle.ClearAll() and just as the name implies; this clears all objects from our list
        // Again our new public static getter and setter methods were created so we can access and manage Triangle objects that we store in out list of triangles(_instances)
        // here we do not need to include a built-in List<> keyword beside the name of our setter method unlike we did with getter
        // and this is because our setter doesn't really care whether we are returning a list or a dictionary; here our setter method is to clear all the Triangle objects we have in our list of Triangle(the static field: _instances)
        public static void ClearAll()
        {
            _instances.Clear();
            // within the method body, we call on the built-in List<T>.Clear() method
            // we added void here since all our ClearAll() method is doing is to clear the entire Field and not return us anything ulike the getter
        }


        public string CheckType()
        {
            // the first branching would be for the logic: not a triangle
            // You should already know one of the basic rules of triangle states that: the addition of 2 other sides must be equal one of the side... and with the below branching we were able to achieve that rule for all Triangles

            if (_side1 > (Side2 + Side3) || Side2 > (_side1 + Side3) || Side3 > (_side1 + Side2))
            {
                _instances.Add(this);
                string myReturn = return "not a triangle";
                // return "not a triangle";
            }
            // for the 2nd branch we determine if none of the 3 sides are equal, then we know it is a scalene triangle
            else if ((_side1 != Side2) && (Side2 != Side3) && (_side1 != Side3))
            {
                _instances.Add(this);
                return "Scalene Triangle";
            }
            // the next branch deterines if our triangle is an equilateral triangle; don't forget thecomparism operator in C# is '==' and not '===' lke in JavaScript
            else if ((_side1 == Side2) && (_side1 == Side3))
            {
                _instances.Add(this);   
                return "Equilateral triangle";

            }
            else
            {
                _instances.Add(this);
                return "Isoceles triangle";
            }

            // Like I said before, this method is exactly the same with the one written in JavaScript; so for more understanding you can check out the Javascript version for this app which is the version 1.0.0


        }

        // We can easily call our method in our UI logic file(Program.cs)



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



// Now moving on with my application
// TOPIC: ACCESS MODIFIERS, BEST PRACTICES WITH FIELDS AND Getter and Setter METHODS
// At this point, we now have the business logic functionality that we need to create a shape tracker app that functions the same as our JS version
// But there is a bit more C# basics we need to learn and apply to our Triangle model before moving onto our user Interface logic
// NOTE: It is NOT considered best practice to give fields a "public" level of access... You will soon know why and how you'll need to create "getter" and "setter" methods for our fields.
// LEARNING ACCESS LEVEL MODIFIERS ===>
// Access level modifiers also called access modifiers are applied to classes and ay class member, and they control how the class or class member can be accessed within oroutside of an assembly.
// And a class member is any field, method, or constructor declared within a class.
// An assembly is one or more executable output files created after we compile our code with the command(dotnet build). Assembly files end in .dll or .exe (depending on your operating system), and we can find these in our project's bin folder. The projects we create will have a varying number of files in each assembly, and we don't need to worry about keeping track of them.

// In other words, access level modifier control the visibility of a class or class member: the degree to which a class or class member can be seen. For example, if a field is private it can only be seen within the class. if a field is public, it can be seen anywhere in the application

// As we said earlier on, the best practice for class fields is to set them as private. Why? when we make our field public it means any method anywhere could change the field of an object and this leads to code that isn't very secure or scalable
// When we declare fields private instead of public, this means only code within the class can directly access these fields. Any code outside the class will not have this access. This is far more secure and considered best practice. However, when we make our fields private, it prevents us from being able to directly set or retrieve fields from outside of the class with object notation like this: testTriang.Side1;
// this is a bit awkward... the best practice dictates that the field should be private to the class, and yet we need to access the field from outside the class! More than awkward it seems unimaginable!

// Well there are special methods we can create to access or alter object fields without breaking these rules. These methods are called getters and setters
// We have updated all of our fields to have the private access modifier and how do we do that?
// We basically followed the new naming convention; private and internal fields follow lower camel case and are preceded by an _underscore 
// For example, the public field Side1 is now the private field _side1. This naming convention exists in order to easily distinguish public and private/internal fields
// after we used access modifier private, we need to create Getter and Setter methods so Program.cs(our UI logic file) can access the field and not work with the private field's protection level.
// CREATING Getter and Setter methods.... Both getter and setter methods allow is to get and set information from outside of the private field's class. As their names mply; getters are methods that "get" information and setters are methods that "set" information
// After adding 3 public getter methods, one for each of our private fields: GetSide1(), GetSide2(), and GetSide3()... all getter methods follow the same naming convention of: Get + NameOfField in Pascal case
// As we can see these getter methods only handle returning thte field(don't forget a getter helps to get information).
// However, we could update these methods to do more actions than just return the field. In this way, we have control over how the data for each field is returned.
// Finally, note that we don't have to create a getter method for every private field. If we don't need to access the field publicly, then we really don't need to create a getter method for it. Getter methods should be created on an as-needed basis(i.e only when you need them)

// NEXT LESSON: There are still a lot of things to be aded into my app, and we wll be walking through each of those things