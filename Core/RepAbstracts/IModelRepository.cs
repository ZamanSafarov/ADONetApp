using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.RepAbstracts
{
    public interface IModelRepository<T>
    {
        void Add(string command);
        void Delete(string command);
        void Update(string command);
        T Get(string command);
        List<T> GetAll(string command);
    }
}
