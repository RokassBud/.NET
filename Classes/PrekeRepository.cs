namespace Sandelis{
    public class PrekeRepository{

        List<Preke> lpreke = new List<Preke>();

        public void Insert(Preke preke){
            lpreke.Add(preke);
            ListToXML.AddPreke(lpreke);
        }
        
        public void Update(){

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