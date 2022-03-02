using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public interface IDataAccess<TEntity, in TPk> where TEntity : class
    {
        IEnumerable<TEntity> GetData();
       
        TEntity Create(TEntity entity);
        TEntity Update(TPk id, TEntity entity);
        TEntity Delete(TPk id);
    }
    public interface IDataAccessReport<TEntity , in Tpk> where TEntity : class
    {
        void GetAllEmployeeByDeptName(Tpk dname);

        void GetAllEmployeesWithMaxSalByDeptName(Tpk dname);

        void GetSumSalaryByDeptName(Tpk dname);
        void GetAllEmployeesByLocation(Tpk dname);
    }
    }

