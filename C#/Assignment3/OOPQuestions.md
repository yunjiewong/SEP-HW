<h2 align="center"> OOP</h2>

#### 

1. What are the six combinations of access modifier keywords and what do they do? 
  - public: accessible from everywhere in a project without any restrictions
  - private: accessible only inside a class or a structure
  - protected: accessible inside the class and in all classes that derive from that class
  - internal:accessible within the current project assembly
  - protected internal:access the protected internal member only in the same assembly or in a derived class in other assemblies
  - private internal: access members inside the containing class or in a class that derives from a containing class, but only in the same assembly
  

2. What is the difference between the static, const, and readonly keywords when applied to a type member?
  - constant and readonly are used to make a field constant that cannot be modified
  - constant is initialized during compile time, readonly is during run-time
  - static makes members static that can be shared by all class objects

3. What does a constructor do?
  - a special method of a class or structur that initializes a newly created object of that type

4. Why is the partial keyword useful?
  - partial is good for splitting the functionality of methods, interface,struct into multiple files

5. What is a tuple?
  - a data structure consists of the multiple parts
6. What does the C# record keyword do?
  - record class:  clarify a reference type
  - record struct to define a value type with similar funcitonality

7. What does overloading and overriding mean?
  - overloading: two or more methods in one class have the same method name but different parameter
  - overriding: when two methods have same signature
  
  
8. What is the difference between a field and a property?
  - field: variables declared in a class
  - property: can read, write or compute the value of a field
  
9. How do you make a method parameter optional?
  - set a default value
  - use method overloading
  - use optional
  - use params

10. What is an interface and how is it different from abstract class?
  - interface: a constract only declaration no implementation
  - interface can not have constractors, abstract class can
  - interface can't have fields, but property
  
11. What accessibility level are members of an interface?
  - bu default public


12. Polymorphism allows derived classes to provide different implementations
of the same method. **T**

13. The override keyword is used to indicate that a method in a derived class is
providing its own implementation of a method.  **T**

14. The new keyword is used to indicate that a method in a derived class is
providing its own implementation of a method  **F**

15. Abstract methods can be used in a normal (non-abstract) class.  T
16.  Normal (non-abstract) methods can be used in an abstract class. F
17.  Derived classes can override methods that were virtual in the base class. T
18.  Derived classes can override methods that were abstract in the base class. F
19.  In a derived class, you can override a method that was neither virtual non abstract in the
base class. T
20. A class that implements an interface does not have to provide an
implementation for all of the members of the interface. F
21.  A class that implements an interface is allowed to have other members that
aren’t defined in the interface. T
22. A class can have more than one base class. F
23.  A class can implement more than one interface. T





