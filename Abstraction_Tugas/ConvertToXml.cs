using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Serialization;
namespace Abstraction_Tugas
{
    public class ConvertToXml : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(ConvertToXml));
            serializer.Serialize(Console.Out, mhs);
            string xml = Console.Out.ToString();
            Console.WriteLine("Hasil Konversi ke XML");
            Console.WriteLine(xml);
        }
    }
}
