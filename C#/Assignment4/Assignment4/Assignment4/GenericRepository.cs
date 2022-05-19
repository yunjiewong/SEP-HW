using System;

namespace Assignment4
{
	public class GenericRepository<T>: IRepository<T> where T:class
	{
        T[] table = null;
		public GenericRepository()
		{

		}

        public void Add(T item)
        {
            table.Add(item);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(int id)
        {
            return table.Find(id);
        }

        public void Remove(T item)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}

