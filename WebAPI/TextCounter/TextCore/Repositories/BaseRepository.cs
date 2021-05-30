using TextCore.Repositories.Interfaces;
using TextInfrastructure;
using TextInfrastructure.Models;
using System.Collections.Generic;
using System.Linq;

namespace TextCore.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly TextContext _context;

        protected BaseRepository(TextContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }
    }
}
