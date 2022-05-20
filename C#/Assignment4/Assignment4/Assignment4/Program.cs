// See https://aka.ms/new-console-template for more information
using Assignment4;
using Assignment4.Entity;

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


//var list = new MyList<int>(3);
//list.Add(1);
//list.Add(2);
//list.Add(4);
//list.Remove(2);

//int i = list.Find(1);
//Console.WriteLine(i);
//bool c = list.Contains(3);
//Console.WriteLine(c);
//list.DeleteAt(1);

var d1 = new Department() { Id = 1, Name = "A",Location = "1"};
var d2 = new Department() { Id = 2, Name = "B", Location = "2" };
var d3 = new Department() { Id = 3, Name = "C", Location = "3" };

var gen = new GenericRepository();
gen.Add(d1);
gen.Add(d2);
gen.Add(d3);
var list = gen.GetAll();
foreach(var l in list)
{
    Console.WriteLine(l.ToString());
}

var elem = gen.GetById(3);
 Console.WriteLine(elem.ToString());