using ETCS.Model;
using ETCS.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS.Factories
{
    public interface IRepoFactory
    {
        IRepo<T> CreateRepo<T>() where T : BaseEntity;
    }
}
