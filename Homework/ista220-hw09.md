## Ricardo Rosa

### ISTA220 Homework 9

### C# 

### *Read chapter 9, pages 201 – 219 in the C# Step by Step book.*


##### 1. Declare an enum for military ranks, either officer or enlisted. Name it Ranks. What are the symbols, like Private, PFC, Corporal, or 1stLt, 2ndLt, Capt?

enum Rank { PVT, PFC, SPC, SGT }


##### 2. Using the Ranks enum, assign a rank to yourself or a friend.
Rank Ricardo; Ricardo = Rank.SPC;


##### 3. Determine the numeric index of particular ranks, using the Ranks enum.
Console.WriteLine((int)Ricardo);

##### 4. How do you select the type of an enum?
enum Rank : short { PVT, PFC, SPC, SGT }

##### 5. Are structs stored on the stack or on the heap? What about enums?
Structures are stored on the stack. 
Enums are stored on the stack as well.
##### 6. Declare a struct named DOD with four branches.
struct DOD
{
string army, navy, airforce, marines;
}

##### 7. Why can’t you create a default constructor for a struct?
The Compiler always generates one.

##### 8. What is CIL? What does the CLR do to the CIL?CIL a pseudo-machine code (Common Intermediate Language)The CLR converts the CIL instructions into real machine instructions that the processor on your computer can understand an execute.