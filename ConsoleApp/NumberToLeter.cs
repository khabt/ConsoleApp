// Decompiled with JetBrains decompiler
// Type: EInvoice.Core.NumberToLeter
// Assembly: EInvoice.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 934AAB00-EA19-4604-9B7D-18062F1F7896
// Assembly location: C:\Users\HP\AppData\Roaming\Skype\My Skype Received Files\EInvoice.Core.dll

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace ConsoleApp
{


    public class NumberDolarToLetter
    {
        class CurrencyUnit
        {
            public string IntName { get; set; }
            public string DecimalName { get; set; }
            public int RoundNumber { get; set; }
            public CurrencyUnit(string intName, string decimalName, int roundNumber)
            {
                this.IntName = intName;
                this.DecimalName = decimalName;
                this.RoundNumber = roundNumber;
            }
        }


        private static readonly string[] ChuSo = new string[10] { " không", " một", " hai", " ba", " bốn", " năm", " sáu", " bẩy", " tám", " chín" };
        private static readonly string[] Tien = new string[6] { "", " nghìn", " triệu", " tỷ", " nghìn tỷ", " triệu tỷ" };
        private static readonly IDictionary<string, CurrencyUnit> CurrencyUnitDic = new Dictionary<string, CurrencyUnit>()
        {
            {"USD",new CurrencyUnit("đô la mỹ","cents",2)},
            {"EUR",new CurrencyUnit("Euro","cents",2)},
            {"VND",new CurrencyUnit("đồng","",0)},
            {"JPY",new CurrencyUnit("Yên","",0)},
            {"GBP",new CurrencyUnit("bảng Anh","pence",2)},
            {"SGD",new CurrencyUnit("đô la Sing","cents",2)},
            {"MYR",new CurrencyUnit("đô la Malaysia","cents",2)},
        };



        // Hàm đọc số thành chữ
        public static string GetAmountInWords(decimal amount, string currencyCode = "")
        {
            if (currencyCode == null)
                currencyCode = "VND";
            currencyCode = currencyCode.ToUpper();
            CurrencyUnit currencyUnit = CurrencyUnitDic.ContainsKey(currencyCode) ? CurrencyUnitDic[currencyCode] : null;
            if (currencyUnit.RoundNumber > 0)
            {
                long intValue = (long)amount;
                amount = decimal.Round(amount, currencyUnit.RoundNumber, MidpointRounding.AwayFromZero);
                var ret = string.Empty;
                var decimalValue = amount - intValue;
                decimalValue *= 100;
                decimalValue = decimal.Round(decimalValue, 0, MidpointRounding.AwayFromZero);

                if (intValue > 0)
                {
                    ret = GetAmountInWords(intValue, currencyUnit.IntName, false);
                }
                if (decimalValue > 0)
                {
                    var decimalStr = decimalValue.ToString(CultureInfo.InvariantCulture);
                    var array = decimalStr.Select(t => int.Parse(t.ToString())).Reverse().ToArray();
                    var tem = decimalStr.Length == 1 ? array[0] : array[1] * 10 + array[0];
                    if (ret.Length > 0)
                        ret += " và";
                    ret += DocSo3ChuSo(tem, false);
                    ret += " " + currencyUnit.DecimalName;
                }
                ret = ret.Substring(0, 1).ToUpper() + ret.Substring(1) + ".";
                return ret;
            }
            return GetAmountInWords((long)amount, currencyUnit.IntName);
        }
        private static string GetAmountInWords(long soTien, string currency, /*string evenText,*/ bool includeDot = true)
        {
            int lan, i;
            long so;
            string ketQua = "";
            int[] viTri = new int[6];
            if (soTien < 0) return "Số tiền âm!";
            if (soTien == 0) return "Không đồng!";
            if (soTien > 0)
            {
                so = soTien;
            }
            else
            {
                so = -soTien;
            }
            //Kiểm tra số quá lớn
            if (soTien > 8999999999999999)
            {
                soTien = 0;
                return "";
            }
            viTri[5] = (int)(so / 1000000000000000);
            so = so - long.Parse(viTri[5].ToString()) * 1000000000000000;
            viTri[4] = (int)(so / 1000000000000);
            so = so - long.Parse(viTri[4].ToString()) * +1000000000000;
            viTri[3] = (int)(so / 1000000000);
            so = so - long.Parse(viTri[3].ToString()) * 1000000000;
            viTri[2] = (int)(so / 1000000);
            viTri[1] = (int)((so % 1000000) / 1000);
            viTri[0] = (int)(so % 1000);
            if (viTri[5] > 0)
            {
                lan = 5;
            }
            else if (viTri[4] > 0)
            {
                lan = 4;
            }
            else if (viTri[3] > 0)
            {
                lan = 3;
            }
            else if (viTri[2] > 0)
            {
                lan = 2;
            }
            else if (viTri[1] > 0)
            {
                lan = 1;
            }
            else
            {
                lan = 0;
            }
            for (i = lan; i >= 0; i--)
            {
                bool isDoc = false;
                if (viTri[i].ToString().Length < 3 && i < lan)
                {
                    string testing = viTri[i].ToString();
                    isDoc = true;
                    //ViTri[i] = AddZero(ViTri[i]);
                }
                var tmp = DocSo3ChuSo(viTri[i], isDoc);
                isDoc = false;
                ketQua += tmp;
                if (viTri[i] != 0) ketQua += Tien[i];
                if ((i > 0) && (!string.IsNullOrEmpty(tmp))) ketQua += "";//&& (!string.IsNullOrEmpty(tmp))
            }
            if (ketQua.Substring(ketQua.Length - 1, 1) == ",") ketQua = ketQua.Substring(0, ketQua.Length - 1);
            ketQua = ketQua.Trim();
            //if (soTien.ToString()[soTien.ToString().Length - 1] == '0')
            //    currency = currency + evenText;
            return ketQua.Substring(0, 1).ToUpper() + ketQua.Substring(1) + " " + currency + (includeDot ? "." : "");
        }

        private string AddZero(string str)
        {
            if (str.Length == 2)
                str = "0" + str;
            else if (str.Length == 1)
                str = "00" + str;
            return str;

        }

        // Hàm đọc số có 3 chữ số
        private static string DocSo3ChuSo(int baso, bool isDoc0)
        {
            string ketQua = "";
            var tram = (int)(baso / 100);
            var chuc = (int)((baso % 100) / 10);
            var donvi = baso % 10;
            if ((tram == 0) && (chuc == 0) && (donvi == 0)) return "";
            if (tram != 0 || isDoc0)
            {
                ketQua += ChuSo[tram] + " trăm";
                if ((chuc == 0) && (donvi != 0)) ketQua += " linh";
            }
            if ((chuc != 0) && (chuc != 1))
            {
                ketQua += ChuSo[chuc] + " mươi";
                if ((chuc == 0) && (donvi != 0)) ketQua = ketQua + " linh";
            }
            if (chuc == 1) ketQua += " mười";
            switch (donvi)
            {
                case 1:
                    if ((chuc != 0) && (chuc != 1))
                    {
                        ketQua += " mốt";
                    }
                    else
                    {
                        ketQua += ChuSo[donvi];
                    }
                    break;
                case 5:
                    if (chuc == 0)
                    {
                        ketQua += ChuSo[donvi];
                    }
                    else
                    {
                        ketQua += " lăm";
                    }
                    break;
                default:
                    if (donvi != 0)
                    {
                        ketQua += ChuSo[donvi];
                    }
                    break;
            }
            return ketQua;
        }


    }


    public class NumberToLeterEng
    {
        private static string[] ChuSo = new string[10]
        {
      " Zero",
      " One",
      " Two",
      " Three",
      " Four",
      " Five",
      " Six",
      " Seven",
      " Eight",
      " Nine",
        };
        private static string[] ChuSoNhoHon20 = new string[20]
       {
      " Zero",
      " One",
      " Two",
      " Three",
      " Four",
      " Five",
      " Six",
      " Seven",
      " Eight",
      " Nine",
      " Ten",
      " Eleven",
      " Twelve",
      " Thirteen",
      " Fourteen",
      " Fifteen",
      " Sixteen",
      " Seventeen",
      " Eighteen",
      " Nineteen"
       };
        private static string[] ChuSoHangChuc = new string[10]
      {
      " zero",
      " ten",
      " Twenty",
      " Thrity",
      " Forty",
      " Fifty",
      " Sixty",
      " Seventy",
      " Eighty",
      " Ninety"
      };


        public string DocTienBangChuEng(long SoTien)
        {
            if (SoTien < 0L)
                return "Minus!";
            if (SoTien == 0L)
                return "Zero!";
            return DocTienBangChu(SoTien) + " VND";

        }

        public string DocTienBangChu(long SoTien)
        {
            var TEN = 10;
            var ONE_HUNDRED = 100;
            var ONE_THOUSAND = 1000;
            var ONE_MILLION = 1000000;
            var ONE_BILLION = 1000000000;
            var ONE_TRILLION = 1000000000000;
            var ONE_QUADRILLION = 1000000000000000;
            var MAX = 9007199254740992;
            string str1 = "";
            long remainder = 0;
            if (SoTien < 20)
            {
                remainder = 0;
                str1 = ChuSoNhoHon20[SoTien];
            }
            else if (SoTien < ONE_HUNDRED)
            {
                remainder = SoTien % TEN;
                str1 = ChuSoHangChuc[(int)(SoTien / TEN)];
                // In case of remainder, we need to handle it here to be able to add the “-”
                if (remainder != 0)
                {
                    str1 += '-' + ChuSoNhoHon20[remainder].Trim();
                    remainder = 0;
                }
            }
            else if (SoTien < ONE_THOUSAND)
            {
                remainder = SoTien % ONE_HUNDRED;
                str1 = DocTienBangChu((SoTien / ONE_HUNDRED)) + " Hundred";
                if (remainder != 0)
                {
                    str1 += DocTienBangChu(remainder);
                    remainder = 0;
                }
            }
            else if (SoTien < ONE_MILLION)
            {
                remainder = SoTien % ONE_THOUSAND;
                str1 = DocTienBangChu((SoTien / ONE_THOUSAND)) + " Thousand";
                if (remainder != 0)
                {
                    str1 += DocTienBangChu(remainder);
                    remainder = 0;
                }
            }
            else if (SoTien < ONE_BILLION)
            {
                remainder = SoTien % ONE_MILLION;
                str1 = DocTienBangChu((SoTien / ONE_MILLION)) + " Million";
                if (remainder != 0)
                {
                    str1 += DocTienBangChu(remainder);
                    remainder = 0;
                }
            }
            else if (SoTien < ONE_TRILLION)
            {
                remainder = SoTien % ONE_BILLION;
                str1 = DocTienBangChu((SoTien / ONE_BILLION)) + " Billion";
                if (remainder != 0)
                {
                    str1 += DocTienBangChu(remainder);
                    remainder = 0;
                }
            }
            else if (SoTien < ONE_QUADRILLION)
            {
                remainder = SoTien % ONE_TRILLION;
                str1 = DocTienBangChu((SoTien / ONE_TRILLION)) + " Trillion";
                if (remainder != 0)
                {
                    str1 += DocTienBangChu(remainder);
                    remainder = 0;
                }
            }
            else if (SoTien <= MAX)
            {
                remainder = SoTien % ONE_QUADRILLION;
                str1 = DocTienBangChu((SoTien / ONE_QUADRILLION)) + " Quadrillion";
                if (remainder != 0)
                {
                    str1 += DocTienBangChu(remainder);
                    remainder = 0;
                }
            }
            return str1;
        }


    }

    public class NumberToLeter
    {
        private static string[] ChuSo = new string[10]
        {
      " không",
      " một",
      " hai",
      " ba",
      " bốn",
      " năm",
      " sáu",
      " bảy",
      " tám",
      " chín"
        };
        private static string[] Tien = new string[6]
        {
      "",
      " nghìn",
      " triệu",
      " tỷ",
      " nghìn tỷ",
      " triệu tỷ"
        };

        public string DocTienBangChu(long SoTien, string currency)
        {
            string str1 = "";
            int[] numArray = new int[6];
            if (SoTien < 0L)
                return "Số tiền âm !";
            if (SoTien == 0L)
                return "Không đồng !";
            long num1 = SoTien <= 0L ? -SoTien : SoTien;
            if (SoTien > 8999999999999999L)
            {
                SoTien = 0L;
                return "";
            }
            numArray[5] = (int)(num1 / 1000000000000000L);
            long num2 = num1 - long.Parse(numArray[5].ToString()) * 1000000000000000L;
            numArray[4] = (int)(num2 / 1000000000000L);
            long num3 = num2 - long.Parse(numArray[4].ToString()) * 1000000000000L;
            numArray[3] = (int)(num3 / 1000000000L);
            long num4 = num3 - long.Parse(numArray[3].ToString()) * 1000000000L;
            numArray[2] = (int)(num4 / 1000000L);
            numArray[1] = (int)(num4 % 1000000L / 1000L);
            numArray[0] = (int)(num4 % 1000L);
            int num5 = numArray[5] <= 0 ? (numArray[4] <= 0 ? (numArray[3] <= 0 ? (numArray[2] <= 0 ? (numArray[1] <= 0 ? 0 : 1) : 2) : 3) : 4) : 5;
            for (int index = num5; index >= 0; --index)
            {
                bool isDoc0 = false;
                if (numArray[index].ToString().Length < 3 && index < num5)
                {
                    numArray[index].ToString();
                    isDoc0 = true;
                }
                string str2 = NumberToLeter.DocSo3ChuSo(numArray[index], isDoc0);
                str1 += str2;
                if (numArray[index] != 0)
                    str1 += NumberToLeter.Tien[index];
                if (index > 0 && !string.IsNullOrEmpty(str2))
                    str1 = str1 ?? "";
            }
            if (str1.Substring(str1.Length - 1, 1) == ",")
                str1 = str1.Substring(0, str1.Length - 1);
            string str3 = str1.Trim();
            return str3.Substring(0, 1).ToUpper() + str3.Substring(1) + " đồng";
        }

        private static string AddZero(string str)
        {
            if (str.Length == 2)
                str = "0" + str;
            else if (str.Length == 1)
                str = "00" + str;
            return str;
        }

        private static string DocSo3ChuSo(int baso, bool isDoc0)
        {
            string str = "";
            int index1 = baso / 100;
            int index2 = baso % 100 / 10;
            int index3 = baso % 10;
            if (index1 == 0 && index2 == 0 && index3 == 0)
                return "";
            if (index1 != 0 || isDoc0)
            {
                str = str + NumberToLeter.ChuSo[index1] + " trăm";
                if (index2 == 0 && index3 != 0)
                    str += " linh";
            }
            if (index2 != 0 && index2 != 1)
            {
                str = str + NumberToLeter.ChuSo[index2] + " mươi";
                if (index2 == 0 && index3 != 0)
                    str += " linh";
            }
            if (index2 == 1)
                str += " mười";
            switch (index3)
            {
                case 1:
                    str = index2 == 0 || index2 == 1 ? str + NumberToLeter.ChuSo[index3] : str + " mốt";
                    goto case 0;
                case 5:
                    str = index2 != 0 ? str + " lăm" : str + NumberToLeter.ChuSo[index3];
                    goto case 0;
                case 0:
                    return str;
                default:
                    str += NumberToLeter.ChuSo[index3];
                    goto case 0;
            }
        }
    }
}
