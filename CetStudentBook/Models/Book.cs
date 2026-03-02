using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CetStudentBook.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Kitap adi zorunlu")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "2-200 karakter olmali")]
        [DisplayName("Kitap Adi")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Yazar zorunlu")]
        [StringLength(200, MinimumLength = 2, ErrorMessage = "2-200 karakter olmali")]
        [DisplayName("Yazar")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Tarih zorunlu")]
        [DataType(DataType.Date)]
        [DisplayName("Yayin Tarihi")]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Sayfa sayisi zorunlu")]
        [Range(1, 10000, ErrorMessage = "1-10000 arasi olmali")]
        [DisplayName("Sayfa Sayisi")]
        public int PageCount { get; set; }

        [Required]
        [DisplayName("Ikinci El")]
        public bool IsSecondHand { get; set; }
    }
}
