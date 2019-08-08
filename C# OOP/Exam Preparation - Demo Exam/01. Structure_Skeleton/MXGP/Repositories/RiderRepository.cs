using MXGP.Models.Riders.Contracts;
using MXGP.Repositories.Contracts;
using System.Collections.Generic;
using System.Linq;

namespace MXGP.Repositories
{
    public class RiderRepository : IRepository<IRider>
    {
        private List<IRider> models;

        public RiderRepository()
        {
            models = new List<IRider>();
        }

        public void Add(IRider model)
        {
            models.Add(model);
        }

        public IReadOnlyCollection<IRider> GetAll()
        {
            return models.AsReadOnly();
        }

        public bool Remove(IRider model)
        {
            return models.Remove(model);
        }
        public IRider GetByName(string name)
        {
            return models.FirstOrDefault(m => m.Name == name);
        }
    }
}
