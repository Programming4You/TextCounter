using TextInfrastructure.Models;
using System.Collections.Generic;

namespace TextCore.Repositories.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
    }
}
