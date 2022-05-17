<h2 align="center"> Arrays and Strings</h2>

#### 1.When to use String vs. StringBuilder in C# ?
  - If a string is going to remain constant throughout the program, then use String class
  - If a string can change(insert, delete, etc), then use StringBuilder

#### 2.What is the base class for all arrays in C#?
  - The Array class is the base class for all the arrays in C#

#### 3. How do you sort an array in C#?
  - Array.Sort()

#### 4. What property of an array object can be used to get the total number of elements in an array?
  - Length
  
#### 5.Can you store multiple data types in System.Array?
  - No

#### 6.What’s the difference between the System.Array.CopyTo() and System.Array.Clone()?
 - Clone() returns a new array object containing all the elements in the original array
 - CopyTo() copies the elements into another existing array

<h3 align="center"> Part2 </h3>
 #### 1. Copy an array
     
     int[] array1 = new int[10] {1,2,3,4,5,6,7,8,9,10};
     int[] array2 = new int[array1.Length];
     
     for(int i = 0; i < array1.Length; i++)
     {
         array2[i] = array1[i];
     }
     
     foreach(int i in array1)
        Console.Write(i + " ");
        
    Console.WriteLine();
    foreach(int i in array2)
        Console.Write(i + " ");
   
   
 
