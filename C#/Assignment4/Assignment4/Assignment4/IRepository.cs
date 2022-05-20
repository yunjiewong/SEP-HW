using System;
using Assignment4.Entity;

namespace Assignment4
{
	public interface IRepository<T> where T: class
	{
		 void Add(T item);
		 void Remove(T item);
		 void Save();
		 void Update(T item);
		 IEnumerable<T> GetAll();
		T GetById(int id);
       
    }
}

