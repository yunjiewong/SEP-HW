using System;
using System.Data;
using Dapper;
using DapperTutorial.Core.Entities;
using DapperTutorial.Core.Interfaces;
using DapperTutorial.Infrastructure.Data;

namespace DapperTutorial.Infrastructure.Repositories
{
    public class DepartmentRepository : IRepository<Department>
    {

        DapperDbContext dbContext;
        public DepartmentRepository()
        {
            dbContext = new DapperDbContext();

        }

        public int DeleteById(int id)
        {
            using(IDbConnection conn = dbContext.GetConnection())
            {
                return conn.Execute("Delete From Department Where Id = @deptId", new {deptId = id });
            
            }
        }

        public IEnumerable<Department> GetAll()
        {
            IDbConnection conn = dbContext.GetConnection();
            return conn.Query<Department>("Select Id, DName, Loc From Department");
        }

        public Department GetById(int id)
        {
            IDbConnection conn = dbContext.GetConnection();
            return conn.QuerySingleOrDefault<Department>("Select Id, DName, Loc From Department Where id = @DeptId",
                new { DeptId = id});
        }

        public int Insert(Department obj)
        {
            IDbConnection conn = dbContext.GetConnection();
            
            return conn.Execute("Insert Into Department Values(@DName, @Loc)", obj);
           
        }

        public int Update(Department obj)
        {
            IDbConnection conn = dbContext.GetConnection();
            return conn.Execute("Update Department Set DName = @DName, Loc = @Loc where " +
                "id = @id", obj);
        }
    }
}

