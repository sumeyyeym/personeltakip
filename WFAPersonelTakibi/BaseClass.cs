using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedIP = "127.0.0.1";
        }

        public DateTime CreatedDate { get; set; }
        public string CreatedIP { get; set; }
        public string CreatedComputerName { get; set; }
        public int ID { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedIP { get; set; }
        public string ModifiedComputerName { get; set; }
        
    }

    public sealed class Personel : BaseClass
    {
        public string Adi { get; set; }
        public string SoyAdi { get; set; }
        public Gender Cinsiyet { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public Department Departman { get; set; }
        public string Adres { get; set; }
        public string ImgURL  { get; set; }
    }
    public enum Gender { Male, Female, Karışık }
    public enum Department { Finans, İK, Hukuk, Pazarlama, Satış, ARGE, Operasyon, Yönetim, GenelSekreterlik }
}
