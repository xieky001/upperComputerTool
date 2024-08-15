using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.pub
{
    public class meterType
    {
        private string _type;
        public string type {
            get
            {
                return _type;
            }
            set
            {
                _type =  value;
            }
        }

        private string _info { get; set; }
        public string info {
            get
            {
                return _info;
            }
            set
            {
                _info = _type + "|" + value;
            }
        }

        public static List<meterType> getMeterTypeList() {
            List<meterType> myAItems = new List<meterType>();
            myAItems.Add(new meterType() { type = "10", info = "冷水水表" });
            myAItems.Add(new meterType() { type = "11", info = "生活热水水表" });
            myAItems.Add(new meterType() { type = "12", info = "直饮水水表" });
            myAItems.Add(new meterType() { type = "13", info = "中水水表" });
            myAItems.Add(new meterType() { type = "20", info = "热量表(计热量)" });
            myAItems.Add(new meterType() { type = "21", info = "热量表(计冷量)" });
            myAItems.Add(new meterType() { type = "30", info = "燃气表" });
            myAItems.Add(new meterType() { type = "40", info = "如:电度表" });
            return myAItems;
        }
    }
}
