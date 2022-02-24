namespace Sandelis{
    public class Irankiai : Inventorius
    {
        public float PurchaseCost;
        public Irankiai()
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
            Console.WriteLine("Pirkimo kaina:");
            this.PurchaseCost = PatikraFLOAT(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine($"GUID:  {this.GUID} ");
            Console.WriteLine($"Pavadinimas:  {this.Name} " );
            Console.WriteLine($"SerialNumber: {this.SerialNumber} ");
            Console.WriteLine($"Kiekis: {this.Quanity} ");
            Console.WriteLine($"Svoris: {this.Weight} ");
            Console.WriteLine($"Turis: {this.Capacity} ");
            Console.WriteLine($"Pirkimo kaina: {this.PurchaseCost} ");
        }
    
    }
}