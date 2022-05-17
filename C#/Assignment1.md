<h2 align="center"> Assignment 1</h2>


<h3 align="center"> Part 1</h3>
#### 1.Data Types:
  - A person’s telephone number: int
  - A person’s height: float
  - A person’s age: byte
  - A person’s gender: string
  - A person’s salary: ulong
  - A book’s ISBN: string
  - A book’s price: float
  - A book’s shipping weight: float
  - A country’s population: uint
  - The number of stars in the universe: double
  - The number of employees: (50000) ushort

#### 2.What are the difference between value type and reference type variables? What is boxing and unboxing?
  - difference: value type stores the value of variables, reference type stores the position of the variable
  - Boxing is the conversion of a value type to an object type.
  - Unboxing is the conversion of an object type to a value type.


#### 3. What is meant by the terms managed resource and unmanaged resource in .NET?
  - Managed resources are thoe that are pure . NET code and managed by the runtime and are under its direct control.
  - Unmanaged resources are those that are not, Garage Collector doesn't know how to clean up unmanaged resources.

#### 4.Whats the purpose of Garbage Collector in .NET?
  - Garbage Collector is antomatic memory manager, which can release memory automatically, allocate the object on managed heap efficiently


<h3 align="center"> Part 2</h3>


#### 1.What happens when you divide an int variable by 0?
  - It results in error message

#### 2.What happens when you divide an double variable by 0?
  - no error message. It results in Infinity.



 
#### 3.What happens when you overflow an int variable, that is, set it to a value beyond itsrange?
  - it goes back to negative range
  
#### 4. What is the difference between x = y++; and x = ++y;?
  - ++y is preincrement: y increses before the operation
  - y++ is postincrement: y increses after the operation
 
#### 5. What is the difference between break, continue, and return when used inside a loop statement?
  - break: stop iterating the loop
  - continue: skip current iteration, continue to next one till the iterations end
  - return: stop current function and return value
  
#### 6.What are the three parts of a for statement and which of them are required?
  - initialization, condition and incrementation
  
#### 7. What is the difference between the = and == operators?
   - "=" assignment operator
   - "==" comparison operator
 
#### 8. Does the following statement compile? for ( ; true; ) ;
  - yes, infinite loop
 
#### 9. What does the underscore _ represent in a switch expression?
  - replaces the default keyword to signify that it should match anything if reached
  
#### 10.What interface must an object implement to be enumerated over by using the foreach statement?
  - IEnumerable

#### 1.2 Writeline() is not defined, should use Console.WriteLine()

#### 1.3

