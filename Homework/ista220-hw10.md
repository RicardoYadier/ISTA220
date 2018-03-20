## Ricardo Rosa

### ISTA220 Homework 10 

### C# 

***Read chapter 10, pages 221 – 242 in the C# Step by Step book.***


##### 1. What does an array look like in memory?
a contiguous block of memory holding the array elements on the heap, just as a class variable refers to an object on the heap.

##### 2. Where is memory allocated to hold an array, on the stack or on the heap?
it is allocated on the heap.

##### 3. Where is memory allocated to hold an array reference, on the stack or on the heap?
on the Stack

##### 4. Can an array hold values of different types? This is a trick question, the answer is, “It depends.”
an Array can hold objects

##### 5. Describe the syntax of the condition or a foreach loop.


##### 6. How do you make a deep copy of a array?
first you create a new array instance of the same type and the same length as the array you are copying. Second, you copy the data from the original array element by element to the new array, as in this example:

int[] pins = { 9, 3, 7, 2 };
int[] copy = new int[pins.length];
for (int i = 0; <pins.Length; i++)
{
    copy[i] = pins[i];
}

##### 7. What is the difference between a multi-dimensional array and an array of arrays?
Multi [,]
array of array [] []


##### 8. How do you “flatten” a multidimensional array? In other words, take something that looks like a matrix
1 2 3
4 5 6
7 8 9
and turn it into an array [1, 2, 3, 4, 5, 6, 7, 8, 9]?kjh