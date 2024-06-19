using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Abstraction_Tugas
{
    public class ConvertToJson : ConvertObject
    {
        public override void Convert(Mahasiswa mhs)
        {
            string json = JsonConvert.SerializeObject(mhs);
            Console.WriteLine("hasil Konversi ke JSON");
            Console.WriteLine(json);
          
        }
    }
}
