using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testDevice.pub
{
    public class auth
    {
        public static string authEncrypt(string origindata)
        {

            string strHex = origindata;
            if (strHex.Length <= 0) { return ""; }

            int btLen = strHex.Length / 2;
            string strHex1 = dataConvert.strConverse(strHex.Substring(0, btLen));
            byte[] mybytes1 = dataConvert.getBytesFromStrHex(strHex1);
            auth.Card_data(mybytes1, 0x89);
            string strRes1 = dataConvert.getStrHexFromBytes(mybytes1);

            string strHex2 = dataConvert.strConverse(strHex.Substring(btLen, btLen));
            byte[] mybytes2 = dataConvert.getBytesFromStrHex(strHex2);
            auth.Card_data(mybytes2, 0x89);
            string strRes2 = dataConvert.getStrHexFromBytes(mybytes2);

            return strRes2 + strRes1;
        }

        public static void Card_data(byte[] cipher_text, byte sc)
        {
            byte[] code_book = new byte[4] { 154, 169, 57, 147 };
            byte[] kk = new byte[2];
            if (sc == 0)
            {
                kk[0] = 1;
            }
            else
            {
                kk[0] = sc;
            }
            kk[1] = code_book[sc & 3];
            do
            {
                cipher_text[3] = (byte)((cipher_text[3] << 4) | (cipher_text[3] >> 4));
                cipher_text[1] = (byte)(~cipher_text[1]);
                byte C = cipher_text[0];
                cipher_text[0] = (byte)((uint)(cipher_text[0] >> 1) | (cipher_text[1] & 0x80u));
                byte C2 = C;
                C = cipher_text[6];
                cipher_text[6] = (byte)((cipher_text[6] >> 1) | ((C2 & 1) << 7));
                C2 = C;
                C = cipher_text[7];
                cipher_text[7] = (byte)((cipher_text[7] >> 1) | ((C2 & 1) << 7));
                C2 = C;
                C = cipher_text[5];
                cipher_text[5] = (byte)((uint)(cipher_text[5] << 1) | (C2 & 1u));
                C2 = C;
                C = cipher_text[4];
                cipher_text[4] = (byte)((cipher_text[4] << 1) | ((C2 & 0x80) >> 7));
                C2 = C;
                C = cipher_text[2];
                cipher_text[2] = (byte)((uint)(cipher_text[2] >> 1) | (C2 & 0x80u));
                C2 = C;
                C = cipher_text[3];
                cipher_text[3] = (byte)((uint)(cipher_text[3] << 1) | (C2 & 1u));
                C2 = C;
                C = cipher_text[1];
                cipher_text[1] = (byte)((cipher_text[1] << 1) | ((C2 & 0x80) >> 7));
                kk[0]--;
            }
            while (kk[0] > 0);
            cipher_text[1] -= sc;
            cipher_text[3] += sc;
            for (byte i = 0; i < 8; i++)
            {
                cipher_text[i] -= kk[1];
            }
        }
    }
}
