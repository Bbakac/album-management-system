using System.ComponentModel.DataAnnotations;

namespace ProjeKlasoru.Models
{
    public class TblAlbum
    {
        [Key]
        public int Album_Id { get; set; }
        public int Album_No { get; set; }
        public string? Album_Tur { get; set; }
        public string? Sanatci_bilgi { get; set; }
        public string? Album_Adi { get; set; }
        public decimal Album_Fiyat { get; set; }
        public bool yerli { get; set; }
        // MenajerBilgisi alanını kaldırıyoruz
    }
}
