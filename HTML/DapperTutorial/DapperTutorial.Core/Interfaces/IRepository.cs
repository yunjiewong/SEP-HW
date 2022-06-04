using System;
namespace DapperTutorial.Core.Interfaces
{
	public interface IRepository <T> where T: class
	{
		int Insert(T obj);

		int update(T obj);

		int DeleteById(int id);

		IEnumerable<T> GetAll();

		T GetById(int id);


	}
}

