namespace Nova_Poshta.Modules.Vehicles
{
    class Vehicle
    {
        public int StorageVolume { get; set; }
        public int FreeVolume { get; set; }

        private List<Parcel> parcels = new List<Parcel>();
        public Vehicle() { }

        public Vehicle(int x, int y, int z)
        {
            StorageVolume = x * y * z;
            FreeVolume = StorageVolume;
        }

        public void PutInVeh(Parcel parcel)
        {
            if (parcel.ParcelVolume <= FreeVolume)
            {
                FreeVolume -= parcel.ParcelVolume;
                parcels.Add(parcel);
            }
            else
            {
                Console.WriteLine("Error, not enought space in vehicle!\a");
            }
        }

        public void GetInfo()
        {
            Console.WriteLine($"Vehicle type: {this.GetType().Name}, Storage volume: {StorageVolume}, Free volume: {FreeVolume}");
        }
    }
}
