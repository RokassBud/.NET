namespace Sandelis{
    static class MainClass{
        static int Menu()
        {
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);
            if(success == true)
            {
                return number;
            }
            else
            {
                Console.WriteLine("Iveskite skaiciu.");
                Menu();
                return 0;
            }
        }
        static void Main(){
            bool finished = true;
            IrankiaiRepository irankiairep = new IrankiaiRepository();
            PrekeRepository prekerep = new PrekeRepository();
            do{
                Console.WriteLine("1. Sandelyje esantys daiktai");
                Console.WriteLine("2. Prideti iranki");
                Console.WriteLine("3. Prideti preke");
                Console.WriteLine("4. Istrinti daikta ");

                int option = Menu();
                switch(option)
                {
                    case 1:
                        prekerep.Output();
                        irankiairep.Output();
                        break;
                    case 2:
                        Irankiai kirankis = new Irankiai();
                        irankiairep.Insert(kirankis);
                        break;
                    case 3:
                        Preke kpreke = new Preke();
                        prekerep.Insert(kpreke);
                        break;
                    case 4: 
                        Guid GUID;
                        bool found = false;
                        bool ifound = false;
                        Console.WriteLine("Iveskite objekto GUID istrynimui");
                        Guid.TryParse(Console.ReadLine(), out GUID);
                        found = prekerep.Delete(GUID);
                        if(found == false)
                        {
                            ifound = irankiairep.Delete(GUID);
                        }
                        if(found == false && ifound == false)
                        {
                            Console.WriteLine("TOKIO OBJEKTO NERA!");
                        }
                        break;
                }

            }
            while(finished);
        }
    }
}