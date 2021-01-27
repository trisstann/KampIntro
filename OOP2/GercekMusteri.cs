using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual
    class GercekMusteri:Musteri
    {        
        public string TcNo { get; set; } //neden tcno string burada bu veri üzerinde işlem yapmıyorsak string daha iyidir
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
