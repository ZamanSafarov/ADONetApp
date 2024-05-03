using Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Abstracts
{
    public interface IModelService<T>
    {
        void DeleteModel(int id);
        void AddModel(T product);
        void UpdateModel(int id, T newModel);

        T GetModel(int id);
        List<T> GetAllModels();
    }
}
