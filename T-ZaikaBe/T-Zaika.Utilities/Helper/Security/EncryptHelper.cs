using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace T_Zaika.Utilities.Helper.Security
{
    public class EncryptHelper
    {
        public const string g_Key = "_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-_çèe(-è3214dfg987'(-ç_èsdfgk65_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjs4gf9h8j7kghjklmkdfàjsh'(è_çà'(è-:kn,jdf_çèe(-è3214dfg987'(-ç_èsdfgk654gf9h8j7kghjklmkdfàjsgiouysert)à_ç654gf9h8j7kghjklmkdfàsdlkj254897xsghé'(-";
        public static string EnCrypt(string strCryptThis)
        {
            strCryptThis = strCryptThis + ";" + DateTime.Now.Ticks;
            string strEncrypted = "";
            int iKeyChar;
            int iStringChar;
            int iCryptChar;
            string part;

            for (int i = 1; i < strCryptThis.Length; i++)
            {
                iKeyChar = (int)Convert.ToChar(g_Key.Substring(i - 1, 1));
                iStringChar = (int)Convert.ToChar(strCryptThis.Substring(i - 1, 1));
                iCryptChar = iKeyChar ^ iStringChar;
                if (iCryptChar < 16)
                {
                    part = "0" + Convert.ToString(iCryptChar, 16).ToUpper();
                }
                else
                {
                    part = Convert.ToString(iCryptChar, 16).ToUpper();
                }
                strEncrypted += part;
            }
            return strEncrypted;
        }

        public static string DeCrypt(string encryptedchunk)
        {
            string part = "";
            int iKeyChar;
            int iStringChar;
            int iDeCryptChar;
            string strTempEncrypted = "";
            string strDecrypted = "";

            for (int j = 1; j < (encryptedchunk.Length / 2); j++)
            {
                part = encryptedchunk.Substring((2 * j - 2), 2);
                strTempEncrypted += (char)Int16.Parse(part, NumberStyles.AllowHexSpecifier);
            }

            for (int i = 0; i < strTempEncrypted.Length; i++)
            {
                iKeyChar = (int)Convert.ToChar(g_Key.Substring(i, 1));
                iStringChar = (int)Convert.ToChar(strTempEncrypted.Substring(i, 1));
                iDeCryptChar = iKeyChar ^ iStringChar;
                strDecrypted += Convert.ToChar(iDeCryptChar);
            }

            string listevar = strDecrypted;
            var lesvar = listevar.Split(';');

            return lesvar[0];
        }


    }
}
