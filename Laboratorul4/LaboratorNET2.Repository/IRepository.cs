using System;
using System.Collections.Generic;

namespace LaboratorNET2.Repository
{
    public interface IRepository<T>
    {
        void Create(T creationModel);
        void Update(Guid id, T updateModel);
        void Delete(Guid id);
        T GetById(Guid id);
        IEnumerable<T> GetAll();
    }
}