using System.ComponentModel.DataAnnotations;

namespace TeendoWebApp_13f_1cs_20260924.Models
{
    public class Teendo
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A cím mező kitöltése kötelező!")]
        [StringLength(150, ErrorMessage = "A cím mező maximum 150 karakter hosszú lehet!")]
        public string Cim { get; set; }
        public DateTime Hatarido { get; set; } = DateTime.Today;
        public bool Kesz { get; set; } = false;
    }
}
