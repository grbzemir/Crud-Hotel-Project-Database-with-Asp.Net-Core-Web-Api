using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HotelManagement.Entities
{
    public class Hotel
    {
        //Id alanını primary key olarak verdim ve bu değerin birer birer artmasını istiyorum

        [Key , DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)] 
        public string Name { get; set; }

        [StringLength(50)]
        public string City { get; set; }


    }
}
