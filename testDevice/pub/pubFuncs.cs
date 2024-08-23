using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace testDevice.pub
{
    internal class pubFuncs
    {
        public static void showInfoByTextBox(System.Windows.Forms.Form fm, RichTextBox tbb, string msg,Boolean isWarn = false)
        {
            try
            {
                fm.Invoke(
                    new Action(() => {
                        int b = tbb.Text.Length;
                        tbb.AppendText(msg + Environment.NewLine);
                        if (isWarn)
                        {
                            tbb.Select(b, msg.Length);
                            tbb.SelectionIndent = 30;
                            tbb.SelectionColor = Color.Red;
                        }
                        tbb.ScrollToCaret();
                    })
                 );
            }
            catch (Exception e) { }
        }

        public static void cmbItemsManage(System.Windows.Forms.Form fm,System.Windows.Forms.ComboBox cbb, string optmethod, string itemvalue)
        {
            try {
                fm.Invoke(
                    new Action(() => {
                        if (optmethod.ToLower() == "add")
                        {
                            cbb.Items.Add(itemvalue);
                        }

                        if (optmethod.ToLower() == "remove")
                        {
                            cbb.Items.Remove(itemvalue);
                        }

                        if (optmethod.ToLower() == "clear")
                        {
                            cbb.Items.Clear();
                        }
                    }));
            }
            catch (Exception e) { }
        }
    }
}
