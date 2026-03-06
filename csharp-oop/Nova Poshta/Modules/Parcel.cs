

namespace Nova_Poshta.Modules
{
    internal class Parcel
    {
        public int ParcelVolume { get; set; } // Обьєм посылки

        public Parcel(int x, int y, int z)
        {
            if (x > 0 && y > 0 && z > 0)
            {
                ParcelVolume = x * y * z;
                Console.WriteLine("Parcel created!");
                return;
            }
            else
            {
                Console.WriteLine("Error, size not valid!\a");
                return;
            }
        }
    }
}