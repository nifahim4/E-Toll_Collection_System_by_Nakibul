using ETCS.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS.Repositories
{
    public class GenericRepo<T> : IRepo<T> where T : BaseEntity
    {
        private readonly IList<T> data;

        public GenericRepo(IList<T> data)
        {
            this.data = data;
        }

        public void Add(T entity)
        {
            this.data.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            foreach (var entity in entities)
            {
                this.data.Add(entity);
            }
        }
        

        public void Delete(int id)
        {
            var entity = this.data.FirstOrDefault(e => e.id == id);
            if (entity != null)
            {
                this.data.Remove(entity);
            }
        }

        public List<T> GetAll()
        {
            return this.data.ToList();
        }

        public T GetById(int id)
        {
            return this.data.FirstOrDefault(e => e.id == id);
        }

        public void Update(T entity)
        {
            var existingEntity = this.data.FirstOrDefault(e => e.id == entity.id);
            if (existingEntity != null)
            {
                this.data.Remove(existingEntity);
                this.data.Add(entity);
            }
        }
    }
}
