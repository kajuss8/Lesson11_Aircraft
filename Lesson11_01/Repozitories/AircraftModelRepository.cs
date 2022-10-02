using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repozitories
{
    internal class AircraftModelRepository
    {
        public List<AircraftModel> AircraftModels { get; set; }
        public AircraftModelRepository()
        {
            AircraftModels = new List<AircraftModel>();
            AircraftModels.Add(new AircraftModel(111, "black", 1));
            AircraftModels.Add(new AircraftModel(222, "green", 2));
            AircraftModels.Add(new AircraftModel(333, "red", 3));
        }
        public AircraftModel Retrieve(int id)
        {
            return AircraftModels.Where(c => c.ID == id).FirstOrDefault();
        }
        public List<AircraftModel> Retrieve()
        {
            return AircraftModels;
        }

    }
}
