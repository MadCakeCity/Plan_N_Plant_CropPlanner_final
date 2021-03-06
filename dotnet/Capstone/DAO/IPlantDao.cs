using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Capstone.Models;

namespace Capstone.DAO
{
    public interface IPlantDao
    {
        Plant GetPlantById(int id);
        List<Plant> GetAllPlants();
        List<Plant> GetAllPlantsBySunRequirements(string sun_requirements);
        List<Plant> GetAllPlantsByPlot(int plotId);
        List<PlantedPlant> GetAllPlantingsByPlot(int plotId);
        Plant AddPlant(Plant plantToAdd);
        Plant UpdatePlant(int plantId, Plant updatedPlant);
        bool AddPlantToPlot(PlantingPlant plantReadyForPlanting);
        List<Plant> GetAllPlantsOnFarmList(int userId);
        bool AddPlantToFarmList(Plant plant, int userId);
        bool RemovePlantFromFarmList(ShoppingListItem plant);
        
        /*bool RemovePlantFromPlot(PlantedPlant plantToDigUp);*/
    }
}
