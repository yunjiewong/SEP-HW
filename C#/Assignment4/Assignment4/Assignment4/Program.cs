// See https://aka.ms/new-console-template for more information
using Assignment4;

Console.WriteLine("Hello, World!");



//MyStack<int> s = new MyStack<int> (4);
//s.push(4);
//s.push(5);
//s.push(6);


//int i = s.Count();
//Console.WriteLine(i);

//s.Pop();
//s.Pop();
//i = s.Count();
//Console.WriteLine(i);


var list = new MyList<int>(3);
list.Add(1);
list.Add(2);
list.Add(4);
list.Remove(2);

int i = list.Find(1);
Console.WriteLine(i);
bool c = list.Contains(3);
Console.WriteLine(c);