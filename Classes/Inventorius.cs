namespace Sandelis{
    public class Inventorius{
        public Guid GUID;
        public string? Name;
        public uint SerialNumber;
        public int Quanity;
        public float Weight; 
        public float Capacity;

        public Inventorius(string name, uint snumber, int quanity,float weight, float capacity)
        {
            this.Name = name;
            this.SerialNumber = snumber;
            this.Quanity = quanity;
            this.Weight = weight;
            this.Capacity = capacity;
        }
        public Inventorius(){

        }
        public float PatikraFLOAT(string? pasirinkimas)
        {
            bool correct = false;
            float result = 0;
            do 
            {
                if (float.TryParse(pasirinkimas, out result) && !string.IsNullOrEmpty(pasirinkimas))
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Netinkama ivestis, ivesti is naujo");
                    pasirinkimas = Console.ReadLine();
                }
            }
            while (correct == false);
            return result;
        }
         public int PatikraINT(string? pasirinkimas)
        {
            bool correct = false;
            int result = 0;
            do 
            {
                if (int.TryParse(pasirinkimas, out result) && !string.IsNullOrEmpty(pasirinkimas))
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Netinkama ivestis, ivesti is naujo");
                    pasirinkimas = Console.ReadLine();
                }
            }
            while (correct == false);
            return result;
        }
        public uint PatikraUINT(string? pasirinkimas)
        {
            bool correct = false;
            uint result = 0;
            do 
            {
                if (uint.TryParse(pasirinkimas, out result) && !string.IsNullOrEmpty(pasirinkimas))
                {
                    correct = true;
                }
                else
                {
                    Console.WriteLine("Netinkama ivestis, ivesti is naujo");
                    pasirinkimas = Console.ReadLine();
                }
            }
            while (correct == false);
            return result;
        }
    }
}