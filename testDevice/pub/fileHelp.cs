using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace testDevice.pub
{
    public class fileHelp
    {
        public static string getStringFromFile(string filePath)
        {
            try
            {
                return File.ReadAllText(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return "";
        }

        public static JObject getJobjFromJson(string filePath) {
            return JObject.Parse(getStringFromFile(filePath));
        }

        public static List<T> parseObjFromJsonFile<T>(string filePath)
        {
            string strObj = getStringFromFile(filePath);
            List<T> listObj = JsonConvert.DeserializeObject<List<T>>(strObj);
            return listObj;
        }

        public static List<T> parseObjFromJsonFile<T>(string filePath,string keypath)
        {
            JObject jObj = JObject.Parse(getStringFromFile(filePath));

            string strObjList = jObj[keypath].ToString();
            List<T> listObj = JsonConvert.DeserializeObject<List<T>>(strObjList);
            return listObj;
        }

        //文件保存
        public static Boolean saveFile(string filePath,string fileContent) {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("文件：" + filePath + "不存在！");
                return false;
            }
            try
            {
                File.WriteAllText(filePath, fileContent,Encoding.UTF8);
                return true;
            }
            catch (Exception ex) {                 
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
