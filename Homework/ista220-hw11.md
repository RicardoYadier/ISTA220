## Ricardo Rosa

### ISTA220 Homework 11

### C# 

***Read chapter 11, pages 243 – 254 in the C# Step by Step book.***

##### 1. How do you define a method that takes an arbitrary number of arguments?
You can use a parameter array, which is declared by using the params keyword.

##### 2. How do you call a method that takes an arbitrary number of arguments?
You just use it 

A variadic method

Method (a,c,d,...)
##### 3. Why can’t you use an array to pass an arbitrary number of arguments to a method? 
because you can't use multidimensional arrays.


##### 4. How many parameters can a method have?
It can have as many methods as you want to.

A method can accept any amount of arguments. 

##### 5. Do parameter arguments have to have the same type?
NO

##### 6. What is the difference between a method that takes a parameter argument and one that takes optional arguments?
Optional - Has a fixed parameter list, and you can't pass an arbitrary list of arguments Parameter - Has a complementary list of parameters, and none of them has a default value.##### 7. How do you define a method that takes different (and arbitrary) types of arguments?Method(params object[] paramList)