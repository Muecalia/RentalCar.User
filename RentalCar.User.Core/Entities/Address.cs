using System.ComponentModel.DataAnnotations;

namespace RentalCar.User.Core.Entities
{
    public class Address(string cep, string city, string state, string logradouro)
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Cep { get; set; } = cep;
        public string City { get; set; } = city;
        public string State { get; set; } = state;
        public string Logradouro { get; set; } = logradouro;
        //public Donor? Donor { get; set; }        
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;
    }
}
