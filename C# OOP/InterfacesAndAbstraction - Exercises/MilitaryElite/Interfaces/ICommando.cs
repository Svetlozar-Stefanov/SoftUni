using MilitaryElite.Models;
using System.Collections.Generic;

namespace MilitaryElite.Interfaces
{
    public interface ICommando : ISpecialisedSoldier
    {
        List<Mission> Missions { get; }

        void CompleteMission(string mission);
    }
}
