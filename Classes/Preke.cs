namespace Sandelis{
    public class Preke : Inventorius
    {
        public float SellingCost;
        public float PrimeCost;
        public Preke()
        {
            GUID = Guid.NewGuid();
            Console.WriteLine("Pavadinimas:");
            this.Name = Console.ReadLine();
            Console.WriteLine("SerialNumber:");
            this.SerialNumber = PatikraUINT(Console.ReadLine());
            Console.WriteLine("Kiekis:");
            this.Quanity = PatikraINT(Console.ReadLine());
            Console.WriteLine("Svoris:");
            this.Weight = PatikraFLOAT(Console.ReadLine());
            Console.WriteLine("Turis:");
            this.Capacity = PatikraFLOAT(Console.ReadLine());
            Console.WriteLine("Pardavimo kaina:");
            this.SellingCost = PatikraFLOAT(Console.ReadLine());
            Console.WriteLine("Savikaina:");
            this.PrimeCost = PatikraFLOAT(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"GUID:  {this.GUID} ");
            Console.WriteLine($"Pavadinimas:  {this.Name} " );
            Console.WriteLine($"SerialNumber: {this.SerialNumber} ");
            Console.WriteLine($"Kiekis: {this.Quanity} ");
            Console.WriteLine($"Svoris: {this.Weight} ");
            Console.WriteLine($"Turis: {this.Capacity} ");
            Console.WriteLine($"Pardavimo: {this.SellingCost} ");
            Console.WriteLine($"Savikaina: {this.PrimeCost} ");
        }
    }
}