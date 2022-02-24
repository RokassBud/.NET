using System.Xml.Serialization;

namespace Sandelis{
    class ListToXML {
        public static void AddIrankiai(List<Irankiai> lirankiai){
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Irankiai>));
            TextWriter Filestream = new StreamWriter(@"C:\Users\Bendras\Desktop\sadfasdf\failas.xml");
            serialiser.Serialize(Filestream, lirankiai);
            Filestream.Close();
        }
        public static void AddPreke(List<Preke> lpreke){
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Preke>));
            TextWriter Filestream = new StreamWriter(@"C:\Users\Bendras\Desktop\sadfasdf\failas2.xml");
            serialiser.Serialize(Filestream, lpreke);
            Filestream.Close();
        }
    }
}