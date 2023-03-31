using System;
using ShapeTracker.Models; // where we told C# to make use of our Business Logic folder(Models)
// using System.Collections.Generic; // since I want to make use of my List of Triangle in this UI logic file too, I need to add the namespace that is housing C# Lists


// Now to continue, we want to try using our class(which is in our Business logic folder[Models]) in our user Interface logic file(Program.cs)
// For starting, we simply create a new Instance of the Triangle class and print the object to the console
namespace ShapeTracker
{

    class Program
    {
        static void Main()
        {




            // CREATING AN AMAZING UI FOR MY APPLICATION
            // The previous UI I wrote was a UI to practice my nusiness logic and not to create an interactive console app where users can run and interact with through text commands
            // And now, with the below UI logic, I want to create something users can interact with 

            Console.WriteLine("*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~*~");
            Console.WriteLine("Welcome to the Shape Tracker app!");
            Console.WriteLine("We'll calculate what type of triangle you have based off of the lengths of the triangle's 3 sides.");

            // AFTER THE WELCOME MESSAGE, now let;s give our users the ability to create Triangles
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter a number:");
            string stringNumber1 = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            string stringNumber2 = Console.ReadLine();
            Console.WriteLine("Enter a third number:");
            string stringNumber3 = Console.ReadLine();

            // as you already know, Console.ReadLine() only works with strings and here I'm dealing with numbers, so this strings need to be parsed to actual numbers
            int length1 = int.Parse(stringNumber1);
            int length2 = int.Parse(stringNumber2);
            int length3 = int.Parse(stringNumber3);

            // Here is the final line where we actually create a new triangle oject with the user's inputted numbers

            Triangle tri = new Triangle(length1, length2, length3);

            // Now we want to add in a new UI method for editting the Triangle user just created
            // Any new method we create in our Program class(that contains our UI logic) shoul dbe static. We don't want to have to create an instance of the Program class inorder to call the method


            // calling our static-void method that edits triangles my user has just created
            // Note that: since this methods aim is to edit Triangles, then the triangle object(tri) my user has just created needs to be passed into it
            // by passing in tri; it enables us to use and manipulate the same data, even though our logic is separated into multiple methods
            // Take note that it's required for UI methods to be static, but the return type and whether or not we have parameters should be whatever makes sense for our application's needs.
            // Our UI methods need to be static so that we don't have to create an instance of the Program class before calling an of them. Instead, as a static method, we can call on the method directly, anywhere within our class
            ConfirmOrEditTriangle(tri);


            // Now we have called our method and its time to write it, here are  couple of things our method will be doing:
            // 1. Display the values for each triangle's side and ask the user if they inputted the correct values, and gather their response.
            // 2. We evaluate the user's response if the triangles are correct, we'l  move on to checkng the type of triangle 
            // And if the triangle's sides are incorrect, we'll gather new values for the triangle's side and then start the confirmation process all over


        }

            static void ConfirmOrEditTriangle(Triangle tri)
            {
                Console.WriteLine("Please confirm that you enterred in your triangle correctly:");
                Console.WriteLine($"Side 1 has the length of {tri.GetSide1}");
                Console.WriteLine($"Side 2 has the length of {tri.GetSide2}");
                Console.WriteLine($"Side 3 has the length of {tri.GetSide3}");
                Console.WriteLine();
                Console.WriteLine("Is that correct? Enter 'yes' to proceed, or 'no' to re-enter the triangle's sides");
                string userInput = Console.ReadLine().ToUpper();

                // I used .ToUpper() just because I wanted to ensure my application sees a yes as a YES or yES(i.e just ensuring my app works with different forms of capitalization)

                // Now let us move on to branching that determines whether user would like to change the 3 values they gave me for the triangl eobject or not
                if (userInput == "YES")
                {
                    // Here we just call on the .CheckTriangleType() UI method and this chescks the type of a triangle(e.g: isoceles)
                    // we made this a method instead of writing the code here to practice a good separation of concerns(since edit functionality is different from triangle type check functionality its best to separate them into different methods)
                    // Although we have not created that method yet
                    CheckTriangleType();
                }
                else
                {
                    Console.WriteLine("Let's fix your triangle. Please enter the 3 sides again");
                    Console.WriteLine("Please enter a number");
                    Console.WriteLine("Please enter a number:");
                    string stringNumber1 = Console.ReadLine();
                    Console.WriteLine("Enter another number:");
                    string stringNumber2 = Console.ReadLine();
                    Console.WriteLine("Enter a third number:");
                    string stringNumber3 = Console.ReadLine();

                    // Now we call on our setter to set stringNumber1 as the side1 after we have successfully parsed our string into an integer
                    tri.SetSide1(int.Parse(stringNumber1));
                    tri.SetSide2(int.Parse(stringNumber2));
                    tri.SetSide3(int.Parse(stringNumber3));
                    ConfirmOrEditTriangle(tri);

                    // one very important thing to notice is the looping we set at the end of our else-statement... After we gather new triangle values, we call ConfirmOrEditTriangle() again 
                    // This means we'll be prompted again and again to confirm that our triangle's sides are correct unti they actually are.... In other words, the only way to leave the ConfirmOrEditTriangle() method is to verify that the triangle is correct by entering "YES"

                    // In any case, keep in mind that you can create a loop by calling on the same method you are declaring within its own definition(e.g: calling ConfirmOrEditTriangle() within the ConfirmOrEditTriangle() definition)

                }



            }

            // Creating the CheckTriangleType() method
            // Bear in mind that we have already called the CheckTriangleType() method inside ConfirmOrEditTriangle() method and passing in our triangle instance tri

            // Keep in mind that we already have a CheckType() method in our business logic 
            // THe CheckTriangleType() method is a UI method that uses the CheckType() business-logic method to check what type of triangle we have(and the CheckType business logic method can only give us one out of the following: Isoceles, equilateral, scalene, and not a triangle)
            // Again all of this stress is all for one thing: separation of concerns i.e not expanding the function of one method to another but ensuring methodA does things related to functionality A and methodB does things related to functionality B
            // Another example of separation of concern is making an addition method carry out only addition, a subtraction method carry out only subtraction e.t.c and not making your addition method do: addition, subtraction and other things at a time
            // Separation of concern really helps us write good code that can be easily debugged
            // Like other Ui method, the CheckTriangleType() method is static so that we can call it on the class and not the instance.... And this is important for the method to work as expected
            // void here means this method returns nothing
            static void CheckTriangleType(Triangle tri)
            {
                string result = tri.CheckType();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Your result is");
                Console.WriteLine("--------------------------------");
            }

    }
}






























// BELOW IS THE BEGINNING OF THE APPLICATION, AND ABOVE IS HOW I UPDATED MY CODE WITH NEW FEATURES


// we are required to have a static void Main() method(within a class) to be the entry pointto our application
// Any code we add within the Main() method will be run when we run our console app
// It's convention to name the file and class that contains our app's entry point Program... Although you can choose not to name it Program.. I said its a common convention and not a mandatory convention

// Triangle testTriangle = new Triangle(); // here we created a new instance of the Triangleclass with the 
//                                         // we start by creating a variable: Triangle testTriangle, we then use the assignment operator = to set the testTriangle variable to a new Triangle object which we create using the new keyworda nd by invoking the Triangle() constructor method
// Console.WriteLine(testTriangle.GetType()); // then we get and print the type of testTriangle variable to the terminal using Console.WriteLine()

// To avoid us from having to write this entire 'ShapeTracker.Models.Triangle' to make .NET locate our Triangle
// We can easily tell C# to use our Business Logic Folder(Models) and to access our Triangle from that we use Trianle instead of ShapeTracker.Models.Triangle... That was when we did: using ShapeTracker.Models

// ACCESSING FIELDS:
// We want to access one of the firlds we have just created in our Business logic file(Triangle.cs)
// We have initially added a value to the Side2, all we have to do now is work with Side1 and Side3
// testTriangle.Side1 = 65;
// testTriangle.Side2 = 88;
// testTriangle.Side3 = 66;

// It is worthy to note that If I went ahead to do: testTriangle.Side2 = 48; O wpuld be overwriting the initial value I gave to Side2 in my Business logic file(and that initaila value was 4), WHat would be executed would be 48 now because C# has overwritten the previous value of 4
// Later on, we removed the initial value we gave to our Side2

// Console.WriteLine($"Side one of the Triangle: {testTriangle.Side1}");
// Console.WriteLine($"Side two of the Triangle: {testTriangle.Side2}");
// Console.WriteLine($"Side three of the Triangle: {testTriangle.Side3}");
// After adding my 3 fields, here are things to note:
// Similar to Javascript, we use dot notation to access fields, like testTriangle.Side1. Note that we cannot use brackets [] to access fields like we were able to do with Javascript properties. In C# brackets are used to apply indexing, like accessing an array element by its index location.
// Take note that all of the fields we created are instance fields, which means that we access them on an instance of the Triangle class, specifically testTriangle, and not the clas itself
// Within the new Console.WriteLine() statements, notice that we're using string interpolation to combine strings with variables
// Having done all of this, we run our Program with the dotnet run in the ShapeTracker project directory and we'll get our output that displays to us the 3 sides and the Object type(the line we used .GetType() method to know what type of object we were dealing with)

// When we call our constructor, we need to pass in an argument for each parameter, or else we'll get a compiler error.
// Triangle testTriangle = new Triangle(3, 4, 5);

// working with our getter methods in our UI
// Console.WriteLine($"Side one of the Triangle: {testTriangle.GetSide1()}");
// Console.WriteLine($"Side two of the Triangle: {testTriangle.GetSide2()}");
// Console.WriteLine($"Side three of the Triangle: {testTriangle.GetSide3()}");
// Now I have successfully updated my code to make use of the constructor I have just created

// Calling my first Triangle instance method I wrote for Triangle that helps me check the type of a Trianle(whether it be scalene, isoceles, or equilateral)
// Console.WriteLine("Want to know the type of triangle you have?");
// Console.WriteLine($"Your triangle is: {testTriangle.CheckType()}");

// working with our setter methods in our UI
// Console.WriteLine("Updating....");
// testTriangle.SetSide1(44);
// testTriangle.SetSide2(44);
// testTriangle.SetSide3(70);
// Console.WriteLine($"Actually, I've just changed the values of your triangle's sides to {testTriangle.GetSide1()}, {testTriangle.GetSide2()}, and {testTriangle.GetSide3()}.");
// Console.WriteLine($"Now your triangle is: {testTriangle.CheckType()}");

// Now my Beautiful method gets called correctly
// NOTE: the CheckType() method is an instance method and it need to be called on an instance(example) of Triangle class and that is exactly what testTriangle variable is(an instance of a Triangle class)



// As you can above, we have created our 'using System' directive in order to access the Console library so we can write to the terminal
// We've created a new instance of the Trianle class with 

// Notice that we do not need to create a constructor in our class in order to have access to a constructor method. That is because a constructor method is automatically created anytime you create a new class. Later, we'll learn how to customize class constructor methods
// It was because of the above Notice we were able to run our code without having to create a constructor; C# automatically created a constructor method anytime we create a new class

// After running our code(with a dotnet run) we would see the name of our class output in the Terminal.... Moving on, now we know our Triangle class is working and we have successfully created an instance of it
// We used two namespaces in our Shape Tracker app, one for our business logic and another for our userInterface(UI) logic. With these namespaces in place, if we add more userInterface or business logic files later, we can group them into thei appropriate namespace.
// We first added a namespace to Program.cs, this file which is the only userInterface logic for now
// For the sake of conventions:
// 1. It's common to name all namespaces in a project starting with the name of the Project or company
// 2. It's common for entry point of the application to have a namespace name that is just the name of the Project or company.
// 3. When .NET compiles, it locates the entry point of our application by the method name Main() and the fact that it is a static method. So we don't have to worry about our namespace or class name affecting the compiler's ability to locate the Main() method
// The no.3 is basically saying we can name our namespaces anything without having to worry about .NET not being able to compile our code

// Now moving on with my application
// Having talked about APIE Encapsulation, Now its time to update our code further and add may more useful tools
/*   
// updating the entire code to work with the list of triangles(_instances) I now have in me business logic
List<Triangle> allTriangles = Triangle.GetAll(); // first we call our Triangle.GetAll() method to get our static list of triangle objects.... There won't be any triangles in it yet at this time but that doesn't matter because the value of the allTriangles variable will update as we create new triangles
Triangle testTriangle = new Triangle(3, 4, 5);
Triangle secondTriangle = new Triangle(32, 74, 75);

// before the if-statement, we can update our UI logic to clear the triangles before our if statement using the beautiful Triangle.ClearAll() setter-method we wrote in our business logic
// This is used to check if my if-statement and my .ClearAll() setter-method actually works
// Triangle.ClearAll();
// Although I commented it out after I checked whether my if-statement and my .ClearAll() setter-method works

// a branch to determine whether or not if our list of triangles is empty
// in the else-statement we handle all other cases i.e whern they are triangles in our list
if (allTriangles.Count == 0)
{
   Console.WriteLine("There are no triangles");
}
else
{
   Console.WriteLine("Yay! you have triangles");
   // the foreach I have here is saying: for each tri(a new variable that stores a triangle object) in allTriangles, I want to use my getter method(in business logic) to display all of the sides that exists in that particular triangle
   // still in the else-statement if there are triangles, then we loop through the list and print information about each triangle
   Console.WriteLine("--------------------");
   foreach (Triangle tri in allTriangles)
   {
       Console.WriteLine($"Side one of the triangle: {tri.GetSide1()}");
       Console.WriteLine($"Side two of the triangle: {tri.GetSide2()}");
       Console.WriteLine($"Side three of the triangle: {tri.GetSide3()}");
       Console.WriteLine("--------------------");
   }
}

*/
