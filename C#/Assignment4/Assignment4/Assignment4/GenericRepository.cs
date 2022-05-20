using System;
using Assignment4.Entity;

namespace Assignment4
{
	public class GenericRepository: IRepository<Department> 
	{
        List<Department> _table;

		public GenericRepository()
		{
            _table = new List<Department>();
		}
        
        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Add(Department item)
        {
            _table.Add(item);
          
        }

        public IEnumerable<Department> GetAll()
        {
            return _table;
        }

        public Department GetById(int id)
        {
            foreach (Department d in _table)
            {
                if (d.Id == id)
                {
                    return d;
                }
            }
            return null;
        }

        public void Remove(Department item)
        {
            _table.Remove(item);
        }

   
        public void Update(Department item)
        {
            Department d = GetById(item.Id);
            if (d != null)
            {
                d.Location = item.Location;
                d.Name = item.Name;
            }
        }
    }
}

