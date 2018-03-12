## Ricardo Rosa

### ISTA220 Homework 7

### C# 





##### 1. What is a class? According to the book, what does a class “arrange?”
The definition of a type. Arranges information and behavior into meaningful entities

Is the root word for the term classification.

Is a construct that enables you to create your own custom types by grouping together variables of other types, methods and events.


##### 2. What are the two purposes of encapsulation?
1. To combine methods and data within a class; in other words, to support classification.
2. To control the accessibility of the methods and data; in other words, to control the use of the class.


##### 3. How do you instantiate an instance of a class? How do you access that instance?

You instantiate an instances of a class by using the new keyword.

	Class object = new Class();

##### 4. What is the default access of the fields and methods of a class? How do you change the default?
The default access is Private. Write the word Public before its declaration


##### 5. What is the syntax for writing a constructor?

Class Cars

	{ 
		Cars();
			{ ...}
	}

##### 6. What is the difference between class fields and methods, and instance fields ad methods? How do you create class fields and methods?

Instance fields and methods can be inherited from class fields and methods, but not the other way around. Class fields and methods are declared in the body of the class.

##### 7. How do you bring a static class in scope? Why would you want to bring a static class in scope?
name the class and access it with the access operator

##### 8. Can you think of a good reason to create an anonymous class? What is it?
when you want to keep the data private.

##### 9. What is polymorphism as this term is used in computer science? This is not in the book.

Generally, the ability to appear in many forms. In object-oriented programming, polymorphism refers to a programming language's ability to process objects differently depending on their data type or class. More specifically, it is the ability to redefine methods for derived classes

##### 10. What is message passing as this term is used in computer science? This is not in the book.
Message passing is a type of communication between processes. 


##### 11. What was the first object-oriented programming language?

Smalltalk

LISP

##### 12. Consider this quote by Alexander Stepanov:
I find OOP technically unsound. It attempts to decompose the world in terms of interfaces
that vary on a single type. To deal with the real problems you need multisorted algebras
— families of interfaces that span multiple types. I find OOP philosophically unsound. It
claims that everything is an object. Even if it is true it is not very interesting — saying that
everything is an object is saying nothing at all.
##### Who is Alexander Stephanov? What do you think about this quote?Is a Russian computer programmer, best known as an advocate of generic programming and as the primary designer and implementer of the C++ Standard Template Library,[1] which he started to develop around 1992 while employed at HP Labs. He had earlier been working for Bell Labs close to Andrew Koenig and tried to convince Bjarne Stroustrup to introduce something like Ada generics in C++. He is credited with the notion of concept.