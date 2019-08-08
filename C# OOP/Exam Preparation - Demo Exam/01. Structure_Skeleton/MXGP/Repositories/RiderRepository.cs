using MXGP.Models.Riders.Contracts;
using System.Linq;

namespace MXGP.Repositories
{
    public class RiderRepository : Repository<IRider>
    {
        public override IRider GetByName(string name)
        {
            return models.FirstOrDefault(m => m.Name == name);
        }
    }
}
