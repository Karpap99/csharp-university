using Nova_Poshta.Modules;


namespace Nova_Poshta
{
    internal class Commander
    {
        public Commander() {}
        StoreKeeper storeKeeper = new StoreKeeper();

        
        public void AddCar(int x)
        {
            storeKeeper.AddCar(x);
        }

        public void AddParcel(int x, int y, int z)
        {
            storeKeeper.AddParcelToStorage(x, y, z);
        }

        public void SubmergeToVeh()
        {
            storeKeeper.SubmergeParcel();
        }

        public void GetCars()
        {
            storeKeeper.GetCars();
        }
    }
}
