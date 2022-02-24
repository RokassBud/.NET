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
            UI ui = new UI();
            do{
                ui.Menu();
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
                        ui.MenuDelete(prekerep,irankiairep);
                        break;
                    case 5:
                        ui.MenuUpdate(prekerep,irankiairep);
                        break;
                    case 6:
                        ui.MenuGetByName(prekerep,irankiairep);
                        break;
                }

            }
            while(finished);
        }
    }
}