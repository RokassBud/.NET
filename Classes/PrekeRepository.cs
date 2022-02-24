namespace Sandelis{
    public class PrekeRepository{

        List<Preke> lpreke = new List<Preke>();

        public void Insert(Preke preke){
            lpreke.Add(preke);
            ListToXML.AddPreke(lpreke);
        }
        public void GetByName(string name){
            for(int i = 0; i < lpreke.Count; i++)
            {
                if(name == lpreke[i].Name)
                {
                    lpreke[i].Output();
                }
            }
        }
        
        public bool Update(Guid GUID, int choice, string newinfo){
            bool updated = false;
            for(int i = 0; i < lpreke.Count; i++)
            {
                if(GUID == lpreke[i].GUID)
                {
                    switch(choice)
                    {
                        case 1:
                            lpreke[i].Name = newinfo;
                            break;
                        case 2:
                            lpreke[i].SerialNumber = uint.Parse(newinfo);
                            break;
                        case 3:
                            lpreke[i].Quanity = int.Parse(newinfo);
                            break;
                        case 4:
                            lpreke[i].Weight = float.Parse(newinfo);
                            break;
                        case 5:
                            lpreke[i].Capacity = float.Parse(newinfo);
                            break;
                        case 6:
                            lpreke[i].SellingCost = float.Parse(newinfo);
                            break;
                        case 7:
                            lpreke[i].PrimeCost = float.Parse(newinfo);
                            break;      
                    }
                updated = true;
                }
            }
            ListToXML.AddPreke(lpreke);
            return updated;
        }

        public void Output(){
            foreach(Preke preke in lpreke)
            {
                preke.Output();
            }
        }
        public bool Delete(Guid GUIDD){
            bool found = false;
            for(int i = 0; i < lpreke.Count; i++)
            {
                if(GUIDD == lpreke[i].GUID)
                {
                    Console.WriteLine($"Istrinta: {lpreke[i].Name}");
                    lpreke.Remove(lpreke[i]);
                    found = true;
                }
            }
            ListToXML.AddPreke(lpreke);
            return found;
        }
    }
}