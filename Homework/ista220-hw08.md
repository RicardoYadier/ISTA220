## Ricardo Rosa

### ISTA220 Homework 8

### C# 

##### 1. What is the difference between deep copy and shallow copy?
A deep copy contains copies of all the copied method's values. Shallow copies can contain reference types
A shallow copy just copy the memory address.

##### 2. What is the value of a reference after you declare and initialize it?
An address to a location in memory

##### 3. How do you declare a value type?
You declare a value type by labeling a variable with int, float, double, or char
by assigning a primitive data type.

##### 4. How do you declare a reference type?
Create a new instance of the object. (Key word NEW)


##### 5. Does C# allow you to assign NULL to a value type?
No

##### 6. Can you assign a nullable value type to a non-nullable variable of the same type? Why or why not?
No, because you can copy a non-nullable value to a nullable variable, but not the other way around

##### 7. What is the difference between the stack and the heap?
The stack contains referenced boxes of memory, the heap contains a random assortment of boxes that might contain multiple references to the same memory. Stack memory holds values or addresses to referenced locations.

##### 8. What does it mean when we say that all classes are specialized types?


##### 9. What does ref do?  
Ref causes the compiler to pass a reference to the actual argument rather than a copy of the argument (it changes the argument)

##### 10. What does out do?
Out means output, it is a tool for forcing a method to initialize a parameter

##### 11. Describe boxing and unboxing in your own words.


##### 12. What does cast do?
Cast attempts to convert one data type to another. If the data types are compatible, the code compiles okay. Otherwise, it throws an InvalidCastException