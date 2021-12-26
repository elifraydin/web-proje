using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Proje.Models
{
    public class Yemek
    {
        public int Id { get; set; }
        public string YemekAdi { get; set; }
        public string Afis { get; set; }
        public string Tarif { get; set; }
        public int KategoriId { get; set; }
        public Kategori Kategori { get; set; }
        public int? Porsiyon { get; set; }
        public int? PismeSuresi { get; set; }


        [DataType(DataType.Date)]
        public DateTime YuklenmeTarihi { get; set; }

        public int? HazirlanmaSuresi { get; set; }
    }
}
