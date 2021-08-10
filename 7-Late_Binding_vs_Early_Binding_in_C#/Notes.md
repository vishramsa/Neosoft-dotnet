# Late Binding
   ### What is Late Binding
   1.  Objects are dynamic objects
   2.  Achieved by using virtual methods
   3.  Performance : slow as compared to the early binding
   4.  Executes at the Run time
   5.  Variables declared by using dynamic can be an example of late binding.Because type of the variable is decided by the compiler at runtime.
   
   <br/>
   
   #### Example of Late Binding

```
// concept of late binding
using System;
  
class GFG {
    static void Main()
    {
        // Dynamic objects
        dynamic obj = 4;
        dynamic obj1 = 5.678;
  
        // Display the type of objects
        Console.WriteLine("The type of the objects are :");
  
        // GetType() method is 
        // used to get the type
        Console.WriteLine(obj.GetType());
        Console.WriteLine(obj1.GetType());
    }
}
```
<br/>

   ### Compile Time Binding and Late Binding
   1. Binding is an association of function calls to an object.
   2. The binding of a member function, which is called within an object and is called compiler time or static type or early binding.
   3. All the methods are called an object or class name are the examples of compile time binding.
   4. **The binding of the function calls an object at the run time is called run time or dynamic or late binding.**
   5. Late binding is achieved, using virtual methods, the virtual methods are overridden in the derived class as per the specific requirement.

<br/>
<br/>
<br/>
<br/>

# Early Binding