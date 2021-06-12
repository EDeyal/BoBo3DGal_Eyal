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
        string _savePath = "/BOBO3DSaveData.json";
        string _folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"BoBo3DGal_Eyal";
        public void CheckForJsonFile()
        {
            string newFile = "NewFile";
            if(File.Exists(_folderPath + _savePath) == false)
            {
                //File.WriteAllText(_folderPath + _savePath, JsonConverter);
                using (StreamWriter file = File.CreateText(_savePath))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    //serializer.Serialize( _savePath, this);
                }
            }
        }
    }
    
}
