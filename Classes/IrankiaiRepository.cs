namespace Sandelis{
    public class IrankiaiRepository{
        List<Irankiai> lirankis = new List<Irankiai>();

        public void Insert(Irankiai irankiai){
            lirankis.Add(irankiai);
            ListToXML.AddIrankiai(lirankis);
        }

        public void Update(){

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