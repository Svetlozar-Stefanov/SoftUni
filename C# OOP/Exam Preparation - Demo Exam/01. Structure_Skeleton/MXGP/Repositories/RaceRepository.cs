using MXGP.Models.Races.Contracts;
using MXGP.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MXGP.Repositories
{
    public class RaceRepository : IRepository<IRace>
    {
        private List<IRace> models;

        public RaceRepository()
        {
            models = new List<IRace>();
        }

        public void Add(IRace model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<IRace> GetAll()
        {
            return models.AsReadOnly();
        }

        public bool Remove(IRace model)
        {
            return models.Remove(model);
        }
        public IRace GetByName(string name)
        {
            return models.FirstOrDefault(m => m.Name == name);
        }
    }
}
