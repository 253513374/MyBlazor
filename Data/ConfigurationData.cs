using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MyBlazor.Data
{
    public class ConfigurationData
    {

        string filePath = AppDomain.CurrentDomain.BaseDirectory + @"Certificate.json";
       // private List<Certificate> ListRules { get; set; } 

        public ConfigurationData()
        {
          //  ListRules = GetConfigJson();
        }
        public void SaveJson(List<Certificate> ListRules)
        {
            // if (ListRules == null) return;
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
                //创建文本文件Demo.txt，并写入初始字符串"123456789"Could not find a part of the path
                using (var fileStream = new FileStream(filePath, FileMode.CreateNew))
                {
                    string content = JsonSerializer.Serialize(ListRules); ;//向文本文件Demo.txt中写入的内容为"123456789"
                    byte[] data = Encoding.ASCII.GetBytes(content);//使用ASCII码将字符串转换为字节数据，所以一个字符占用一个字节

                    fileStream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            //如果文本文件Demo.txt已经存在，则将其删除
        }


        

        public List<Certificate> GetConfigJson()
        {
            if (!File.Exists(filePath)) return new List<Certificate>() { new Certificate() };
            using (var Filevar = new FileStream(filePath, FileMode.Open))
            {
                using (var read = new StreamReader(Filevar))
                {
                    var json = read.ReadToEnd();
                    return JsonSerializer.Deserialize<List<Certificate>>(json).ToList();
                }
            }
        }




    }
}
