## Ricardo Rosa

### ISTA220 Homework 12

### C# 


***Read chapter 12, pages 255 – 276 in the C# Step by Step book.***


##### 1. How does inheritance promote the principle of don’t repeat yourself (DRY)?
Inheritance allows you to organize classes systematically under umbrellas of similar attributes and functionality.



##### 2. What is the syntax of a derived class that inherits from a base class?
classDerivedClass : BaseClass

##### 3. Do all user defined types (classes and structs) inherit from some base class? If so, what is it?
Yes, The System.Object class is the root class for all classes.

##### 4. What happens if you do not have a default constructor in a base class when creating a derived class?
if you don't have one, the compiler generates a default constructor for you.

##### 5. Can you assign a variable of a derived class to another variable of its base class? Why or why not?
Yes.

##### 6. Can you assign a variable of a derived class to another variable of of a derived class of its base class? Why or why not?


##### 7. Can you assign a variable of a base class to another variable of a derived class? Why or why not?
Yes, because the derived class is type of the base class type.

##### 8. Under what circumstances would you want to use the new keyword when defining a method in a derived class?
if you're sure that you want the two methods to have the same signature.

##### 9. What is a virtual method? Why would you want to define a virtual method?
A method that is intended to be overridden

##### 10. What does override do? Why does it do it?
declares another implementation of the method.

##### 11. How do you define an extension type?
the first parameter must be of the type being extended, preceded by the this keyword.##### 12. Why do you define an extension type?because you want to add functionality to a class.