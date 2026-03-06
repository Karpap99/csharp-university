namespace Nova_Poshta.Modules.Vehicles
{
    internal class Garage
    {
        List<Vehicle> cars = new List<Vehicle>();
        Vehicle vehicle;
        public Garage() { }

        public void AddCar(int x)
        {
            if (x == 1)
            {
                vehicle = new VehicleLittle();
                cars.Add(vehicle);
                return;
            }
            else if (x == 2)
            {
                vehicle = new VehicleMedium();
                cars.Add(vehicle);
                return;
            }
            else if (x == 3)
            {
                vehicle = new VehicleBig();
                cars.Add(vehicle);
                return;
            }
        }


        //Проверить наличие свободной машины
        public bool CheckFreeVehVoid(int packagevolume)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].StorageVolume - cars[i].FreeVolume >= packagevolume)
                {
                    return true;
                }
            }
            return false;
        }

        //Положить коробку в машину
        public void PutInVeh(int packageVolume)
        {
            foreach (Vehicle vehicle in cars)
            {
                if (vehicle.FreeVolume >= 0)
                {
                    if (vehicle.FreeVolume + packageVolume <= vehicle.StorageVolume)
                    {
                        vehicle.FreeVolume = vehicle.FreeVolume + packageVolume;
                        return;
                    }
                }
            }
        }


        public void GetCars()
        {
            string[] arr = new string[cars.Count()];
            if (cars.Count >= 1)
            {
                int i = 0;
                foreach (Vehicle vehicle in cars)
                {
                    i++;
                    Console.WriteLine($"Car{i} taken Volume is {vehicle.FreeVolume} of {vehicle.StorageVolume}");
                }
                return;
            }
            else return;
        }
    }
}
