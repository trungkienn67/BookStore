using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Models
{
    public class ProductModel
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên Sản Phẩm")]

        public string Name { get; set; }

        [Required(ErrorMessage = "Hãy nhập tên Tác Giả")]

        public string Author { get; set; }
        
        [Required(ErrorMessage = "Hãy nhập tên Nhà Xuất Bản")]

        public string Publicser { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required, MinLength(4, ErrorMessage = "Hãy nhập mô tả Sản Phẩm")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Hãy nhập giá của Sản Phẩm")]
        [Range(0.01, double.MaxValue)]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Required, Range(1, int.MaxValue, ErrorMessage = "Chọn một Thể loại")]
        public int CategoryID { get; set; }

        public string Image {  get; set; }

    }
}
