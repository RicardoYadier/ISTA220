## Ricardo Rosa

### ISTA220 Homework 5

#### C# 



##### 1.What is a compound assignment operator? How does it work?

These operators perform the indicated operation on the two operands, and then assign the resulting value to the variable, property, or indexer element given by the left operand.
Updates the value of a Variable.

##### 2.List all the compound assignment operators.

These	 *= /= %= += -=

##### 3.List two ways to increment a numeric variable by 5. List two ways to decrement a numeric variable by
50.

while(number < 50) numer +=
5;

##### 4.How long does a while loop run?

For as long as some condition is true.

##### 5.What happens if you don’t change the loop variable in the body of the while loop block?

Only the first statement that immediately follows the Boolean expression in the while construct will be executed as part of the loop, resulting in difficult to spot bugs.

##### 6.How many parts does a for loop statement have? Can you omit any of them? Can you omit all of them? What happens if you omit all of them?

Three Parts. You can omit any of the three parts. If you omit the Boolean expression, it defaults to true, and the statement runs forever.

##### 7.How do you guarantee that a loop runs at least once?

Make it a do While loop. because its Boolean expression is evaluated after each iteration, so the body always executes at east once.

##### 8.What does the break statement do?

Jumps out of a switch statement; you can also use a break statement to jump out of the body of an iteration statement.

##### 9.What does the continue statement do?

Causes the program to perform the next iteration of the loop immediately ( after reevaluating the Boolean expression).