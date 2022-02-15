using GarageOpener.Models;
using System;
using System.Collections.Generic;

namespace GarageOpener.GarageData
{
    public interface IGarageData
    {

        List<Garage> GetGarages();
        Garage GetGarage(long id);

        Garage GetStatus(bool isOpen);

        Garage AddGarage(Garage garage);

        void DeleteGarage(Garage garage);

        Garage EditGarage(Garage garage);
        
    }
}
