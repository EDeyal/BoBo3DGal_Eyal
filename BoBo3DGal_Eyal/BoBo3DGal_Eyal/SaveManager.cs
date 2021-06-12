using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBo3DGal_Eyal
{
    public class SaveManager
    {
        JsonSerializer serializer = new JsonSerializer();
        public bool ConvertToJson()
        {
            //string json = serializer.Serialize();
            return true;
        }
        Object someObject = new Object();
        void method()
        {
            File.WriteAllText("location", JsonConvert.SerializeObject(someObject));
        }
    }
    public class Object
    {
        int num = 5;
        
    }
    
}
