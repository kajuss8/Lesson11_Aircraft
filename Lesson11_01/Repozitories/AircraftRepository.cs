using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson11_01.Models;

namespace Lesson11_01.Repozitories
{
    internal class AircraftRepository
    {

        public List<Aircraft> Aircrafts { get; set; }
        public AircraftRepository()
        {
            Aircrafts = new List<Aircraft>();
            Aircrafts.Add(new Aircraft(777, 1, 10, 20));
            Aircrafts.Add(new Aircraft(888, 2, 11, 21));
            Aircrafts.Add(new Aircraft(999, 3, 12, 22));
        }
        public Aircraft Retrieve(int id)
        {

            return Aircrafts.Where(c => c.ID == id).FirstOrDefault();
        }

        public List<Aircraft> Retrieve()
        {
            return Aircrafts;
        }





    }
}
