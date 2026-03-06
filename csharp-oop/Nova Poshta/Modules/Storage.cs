using Nova_Poshta.Modules.Vehicles;

namespace Nova_Poshta.Modules
{
    internal class Storage
    {
        private float StorageVolume { get; set; } // Обьєм cклада
        private float CurrentVolume { get; set; } // Текущий обьєм склада
        List<Parcel> parcelqueue = new List<Parcel>(); // Список посылок
        List<Vehicle> vehicles = new List<Vehicle>(); // Список машин
        List<StoreKeeper> storekeepers = new List<StoreKeeper>(); // Список кладовщиков

        public Storage(float storageVolume)
        {
            StorageVolume = storageVolume;
            CurrentVolume = 0;
        }

        public void HireStoreKeeper(StoreKeeper storekeeper)
        {
            storekeepers.Add(storekeeper);
        }

        public void AddVehicle(string VehicleType)
        {
            if
            vehicles.Add(vehicle);
        }


        public void StoreParcel(Parcel parcel)
        {
            if (CurrentVolume + parcel.ParcelVolume <= StorageVolume)
            {
                CurrentVolume += parcel.ParcelVolume;
                parcelqueue.Add(parcel);
                Console.WriteLine("Parcel stored!");
                return;
            }
            else
            {
                Console.WriteLine("Error, not enought space in storage!\a");
                return;
            }
        }

        public Parcel GetSuitableParcel(int availableVolume)
        {
            if(parcelqueue.Count == 0)
            {
                Console.WriteLine("No parcels available!");
                return null;
            }
            foreach (Parcel parcel in parcelqueue)
            {
                if (parcel.ParcelVolume <= availableVolume)
                {
                    parcelqueue.Remove(parcel);
                    CurrentVolume -= parcel.ParcelVolume;
                    return parcel;
                }
            }
            Console.WriteLine("No suitable parcels available!");
            return null;
        }
    }
}
