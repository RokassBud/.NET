namespace Sandelis{
    public class UI{
        public void Menu(){
            Console.WriteLine("1. Sandelyje esantys daiktai");
            Console.WriteLine("2. Prideti iranki");
            Console.WriteLine("3. Prideti preke");
            Console.WriteLine("4. Istrinti daikta");
            Console.WriteLine("5. Atnaujinti jau esama objekta");
            Console.WriteLine("6. Surasti pagal pavadinima");
        }
        public void MenuDelete(PrekeRepository prekerep, IrankiaiRepository irankiairep){
            Guid GUID;
            bool found = false;
            bool nfound = false;
            Console.WriteLine("Iveskite objekto GUID istrynimui");               
            Guid.TryParse(Console.ReadLine(), out GUID);
            found = prekerep.Delete(GUID);
            if(found == false)
            {                   
                nfound = irankiairep.Delete(GUID);
            }
            if(found == false && nfound == false)
            {
                Console.WriteLine("TOKIO OBJEKTO NERA!");
            }
        }
        public void MenuUpdate(PrekeRepository prekerep, IrankiaiRepository irankiairep){
            bool updated = false;
            bool nupdated =false;
            Guid GUIDD;
            string? newinfo;
            int choice;
            Console.WriteLine("Iveskite objekto GUID:");
            Guid.TryParse(Console.ReadLine(), out GUIDD);
            Console.WriteLine("Kuria pozicija keisti? 1. Pavadinimas, 2. SerialN, 3. Kiekis, 4.Svoris, 5. Turis, 6. PardavimoK, 7.SaviK, 8. PirkimoK.");
            int.TryParse(Console.ReadLine(), out choice);
            Console.WriteLine("I ka keisti?");
            newinfo = Console.ReadLine();
            updated = prekerep.Update(GUIDD,choice,newinfo);
            if(updated == false)
            {
                nupdated = irankiairep.Update(GUIDD,choice,newinfo);
            }
            if(updated == false && nupdated == false)
            {
                Console.WriteLine("TOKIO OBJEKTO NERA!");
            }
        }
        public void MenuGetByName(PrekeRepository prekerep, IrankiaiRepository irankiairep){
            string name;

            Console.WriteLine("Iveskite objekto pavadinima");
            name = Console.ReadLine();
            prekerep.GetByName(name);
            irankiairep.GetByName(name);
        }
    }
}