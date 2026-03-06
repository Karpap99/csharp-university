using Nova_Poshta.Modules.Vehicles;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Nova_Poshta.Modules
{
    internal class StoreKeeper
    {
        public StoreKeeper() { }

        public void AddParcelToStorage(int x, int y, int z)
        {
           storage.AddParcelToStorage(x, y, z);
        }

        public void AddCar(int x)
        {
            garage.AddCar(x);
        }

        public void SubmergeParcel()
        {
            int x = storage.GetLastParcel();
            if (garage.CheckFreeVehVoid(x) == true)
            {
                garage.PutInVeh(x);
                Console.WriteLine("Package submerged!");
                return;
            }
            else Console.WriteLine("Error, not enought Space!\a");
        }

        public void GetCars()
        {
            garage.GetCars();
        }
    }
}
