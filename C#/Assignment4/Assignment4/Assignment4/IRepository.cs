﻿using System;
namespace Assignment4
{
	public interface IRepository<T> where T: class. new()
	{
		void Add(T item);
		void Remove(T item);
		void Save();
		IEnumerable<T> GetAll();
		T GetById(int id);
	}
}

