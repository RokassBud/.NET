namespace Sandelis{
    public class IrankiaiRepository{
        List<Irankiai> lirankis = new List<Irankiai>();

        public void Insert(Irankiai irankiai){
            lirankis.Add(irankiai);
            ListToXML.AddIrankiai(lirankis);
        }

        public void GetByName(string name){
            for(int i = 0; i < lirankis.Count; i++)
            {
                if(name == lirankis[i].Name)
                {
                    lirankis[i].Output();
                }
            }
        }
        public bool Update(Guid GUID, int choice, string newinfo){
            bool updated = false;
            for(int i = 0; i < lirankis.Count; i++)
            {
                if(GUID == lirankis[i].GUID)
                {
                    switch(choice)
                    {
                        case 1:
                            lirankis[i].Name = newinfo;
                            break;
                        case 2:
                            lirankis[i].SerialNumber = uint.Parse(newinfo);
                            break;
                        case 3:
                            lirankis[i].Quanity = int.Parse(newinfo);
                            break;
                        case 4:
                            lirankis[i].Weight = float.Parse(newinfo);
                            break;
                        case 5:
                            lirankis[i].Capacity = float.Parse(newinfo);
                            break;
                        case 8:
                            lirankis[i].PurchaseCost = float.Parse(newinfo);
                            break;  
                    }
                updated = true;
                }
            }
            ListToXML.AddIrankiai(lirankis);
            return updated;
        }
        public void Output(){
            foreach(Irankiai irankis in lirankis)
            {
                irankis.Output();
            }
        }
        public bool Delete(Guid GUIDD){
            bool ifound = false;
            for(int i = 0; i < lirankis.Count; i++)
            {
                if(GUIDD == lirankis[i].GUID)
                {
                    Console.WriteLine($"Istrinta: {lirankis[i].Name}");
                    lirankis.Remove(lirankis[i]);
                    ifound = true;
                }
            }
            ListToXML.AddIrankiai(lirankis);
            return ifound;
        }

    }
}