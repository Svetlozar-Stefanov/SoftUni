using MXGP.Models.Motorcycles.Contracts;
using MXGP.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MXGP.Repositories
{
    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private List<IMotorcycle> models;

        public MotorcycleRepository()
        {
            models = new List<IMotorcycle>();
        }

        public void Add(IMotorcycle model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<IMotorcycle> GetAll()
        {
            return models.AsReadOnly();
        }

        public bool Remove(IMotorcycle model)
        {
            return models.Remove(model);
        }
        public IMotorcycle GetByName(string name)
        {
            return models.FirstOrDefault(m => m.Model == name);
        }
    }
}
