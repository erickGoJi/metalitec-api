using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using biz.admin.Paged;
using OfficeOpenXml;

namespace biz.admin.Repository.Generic
{
    public interface IGenericRepository<T>
    {
        void Save();
        void Dispose();
        Task<int> SaveAsync();

        T Add(T t);
        Task<T> AddAsync(T t);

        T Get(int id);
        Task<T> GetAsync(int id);

        int Count();
        Task<int> CountAsync();

        void Delete(T entity);
        Task<int> DeleteAsync(T entity);

        T Update(T t, object key);
        Task<T> UpdateAsync(T t, object key);

        T Find(Expression<Func<T, bool>> match);
        Task<T> FindAsync(Expression<Func<T, bool>> match);

        bool Exists(int id);
        Task<bool> ExistsAsync(int id);
        bool Exists(Expression<Func<T, bool>> match);
        Task<bool> ExistsAsync(Expression<Func<T, bool>> match);

        ICollection<T> FindAll(Expression<Func<T, bool>> match);
        Task<ICollection<T>> FindAllAsync(Expression<Func<T, bool>> match);

        IQueryable<T> FindBy(Expression<Func<T, bool>> predicate);
        Task<ICollection<T>> FindByAsync(Expression<Func<T, bool>> predicate);

        IQueryable<T> GetAll();
        Task<ICollection<T>> GetAllAsync();
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includeProperties);

        PagedList<T> GetAllPaged(int pageNumber, int pageSize);
        Task<PagedList<T>> GetAllPagedAsync(int pageNumber, int pageSize);
        Task<DataTable> WorksheetToTable(ExcelWorksheet worksheet);
    }
}