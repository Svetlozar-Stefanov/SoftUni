using MXGP.Core.Contracts;
using MXGP.Models.Motorcycles;
using MXGP.Models.Motorcycles.Contracts;
using MXGP.Models.Races;
using MXGP.Models.Races.Contracts;
using MXGP.Models.Riders;
using MXGP.Models.Riders.Contracts;
using MXGP.Repositories;
using MXGP.Repositories.Contracts;
using MXGP.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MXGP.Core
{
    public class ChampionshipController : IChampionshipController
    {
        private IRepository<IRider> riders;
        private IRepository<IMotorcycle> motors;
        private IRepository<IRace> races;

        public ChampionshipController()
        {
            riders = new RiderRepository();
            motors = new MotorcycleRepository();
            races = new RaceRepository();
        }


        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            if (!riders.GetAll().Any(r => r.Name == riderName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }

            if (!motors.GetAll().Any(r => r.Model == motorcycleModel))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.MotorcycleNotFound, motorcycleModel));
            }

            IRider rider = riders.GetByName(riderName);
            IMotorcycle motorcycle = motors.GetByName(motorcycleModel);

            rider.AddMotorcycle(motorcycle);

            return string.Format(OutputMessages.MotorcycleAdded, rider.Name, motorcycle.Model);
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            if (!races.GetAll().Any(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }

            if (!riders.GetAll().Any(r => r.Name == riderName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RiderNotFound, riderName));
            }

            IRace race = races.GetByName(raceName);
            IRider rider = riders.GetByName(riderName);

            race.AddRider(rider);

            return string.Format(OutputMessages.RiderAdded, rider.Name, race.Name);
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            if (motors.GetAll().Any(m => m.Model == model))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.MotorcycleExists, model));
            }

            IMotorcycle motorcycle = null;

            if (type == "SpeedMotorcycle")
            {
                motorcycle = new SpeedMotorcycle(model, horsePower);
            }
            else if (type == "PowerMotorcycle")
            {
                motorcycle = new PowerMotorcycle(model, horsePower);
            }

            motors.Add(motorcycle);

            return string.Format(OutputMessages.MotorcycleCreated, motorcycle.GetType().Name, motorcycle.Model);
        }

        public string CreateRace(string name, int laps)
        {
            if (races.GetAll().Any(r => r.Name == name))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceExists, name));
            }

            IRace race = new Race(name, laps);
            races.Add(race);

            return string.Format(OutputMessages.RaceCreated, race.Name);
        }

        public string CreateRider(string riderName)
        {
            if (riders.GetAll().Any(r => r.Name == riderName))
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RiderExists, riderName));
            }

            Rider rider = new Rider(riderName);
            riders.Add(rider);

            return string.Format(OutputMessages.RiderCreated, rider.Name);
        }

        public string StartRace(string raceName)
        {
            if (!races.GetAll().Any(r => r.Name == raceName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceNotFound, raceName));
            }
            if (races.GetAll().FirstOrDefault(r => r.Name == raceName).Riders.Count < 3)
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.RaceInvalid, raceName, 3));
            }

            IRace race = races.GetByName(raceName);
            List<IRider> winnners = race.Riders.OrderByDescending(r => r.Motorcycle.CalculateRacePoints(race.Laps)).ToList();
             
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(string.Format(OutputMessages.RiderFirstPosition, winnners[0].Name, race.Name));
            winnners[0].WinRace();
            sb.AppendLine(string.Format(OutputMessages.RiderSecondPosition, winnners[1].Name, race.Name));
            sb.AppendLine(string.Format(OutputMessages.RiderThirdPosition, winnners[2].Name, race.Name));

            races.Remove(race);

            return sb.ToString().TrimEnd();
        }
    }
}
