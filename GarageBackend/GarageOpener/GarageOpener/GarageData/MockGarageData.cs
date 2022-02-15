using GarageOpener.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GarageOpener.GarageData
{
    public class MockGarageData : IGarageData
    {

        private List<Garage> garages = new List<Garage>()
        {
            new Garage()
            {
                Id = 1,
                Name =  "Esparza Garage",
                IsOpen = true,
            },

            new Garage()
            {
                Id = 2,
                Name =  "Esparza Garage 2"
            }
        };

        public Garage AddGarage(Garage garage)
        {
            throw new NotImplementedException();
        }

        public void DeleteGarage(Garage garage)
        {
            throw new NotImplementedException();
        }

        public Garage EditGarage(Garage garage)
        {
            throw new NotImplementedException();
        }

        public Garage GetGarage(long id)
        {
            return garages.SingleOrDefault(x => x.Id == id);
        }

        public List<Garage> GetGarages()
        {
            return garages;
        }

        public Garage GetStatus(bool isOpen)
        {
            throw new NotImplementedException();
        }
    }
}
