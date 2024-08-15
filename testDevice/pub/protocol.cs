using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace testDevice.pub
{
    public class protocol
    {
        public List<protocolItem> getDataSurce(string protocolType,string filepath)
        {
            List<protocolItem> items = null;
            switch (protocolType)
            {
                case "97":
                    items = dataItems(filepath);
                    break;
                case "07":
                    items = dataItems(filepath);
                    break;
                case "188":
                    items = dataItems(filepath);
                    break;
                default:
                    items = dataItemsEmpty();
                    break;
            }
            return items;
        }

        private List<protocolItem> dataItems(string strpath)
        {
            List<protocolItem> myAItems = new List<protocolItem>();
            List<protocolItem> listDataItem = fileHelp.parseObjFromJsonFile<protocolItem>(strpath);
            foreach (protocolItem pp in listDataItem)
            {
                myAItems.Add(pp);
            }

            return myAItems;
        }

        private List<protocolItem> dataItemsEmpty()
        {
            List<protocolItem> myAItems = new List<protocolItem>();
            myAItems.Add(new protocolItem() { keyFlag = "", keyInfo = "", isCanRead = false, isCanEdit = false, readControlCode = "01",setControlCode = "04" });

            return myAItems;
        }
    }

    public class protocolItem 
    {
        private string _keyFlag;
        public string keyFlag {
            get
            {
                return _keyFlag;
            }
            set
            {
                _keyFlag =  value;
            }
        }
        private string _keyInfo;
        public string keyInfo {
            get {
                return _keyInfo;
            }
            set {
                _keyInfo = _keyFlag + "|" + value;
            }
                
        }
        public Boolean isCanRead { get; set; }
        public Boolean isCanEdit { get; set; }

        public string readControlCode { get; set; }
        public string setControlCode { get; set; }

        public protocolItem(){}
    }
}
