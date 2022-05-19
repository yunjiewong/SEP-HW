<h2 align="center"> Generics</h2>

#### 1. Describe the problem generics address
    Generics allows to define type-safe data structure, without committing to actual data types.

#### 2. How would you create a list of strings, using the generic List class?
    List<string> str = new List<string>();

#### 3. How many generic type parameters does the Dictionary class have?
    two. <Tkey,Tvalue>
    
#### 4. When a generic class has multiple type parameters, they must all match.
    F. they don't have to be of the same type.
    
#### 5. What method is used to add items to a List object?
    ADD
#### 6. Name two methods that cause items to be removed from a List.
    Clear(), RemoveAt()
#### 7. How do you indicate that a class has a generic type parameter?
    there is <T> after class name
#### 8. Generic classes can only have one generic type parameter.
    No. it can have multiple <T,V>
#### 9. Generic type constraints limit what can be used for the generic type.
    Yes. <T> where T: class
#### 10.  Constraints let you use the methods of the thing you are constraining to.
    yes
