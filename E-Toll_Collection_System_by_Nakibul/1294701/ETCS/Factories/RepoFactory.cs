using ETCS.Model;
using ETCS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS.Factories
{
    public class RepoFactory : IRepoFactory
    {
        public IRepo<T> CreateRepo<T>() where T : BaseEntity
        {
            return new GenericRepo<T>(new List<T>());
        }
    }
}
// dependency Injection