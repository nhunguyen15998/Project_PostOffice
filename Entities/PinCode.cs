using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace post_office.Entities
{
    public class PinCode
    {
        [Key]
        public int Id { get; set; }
        public int Name { get; set; }
        public int CityId { get; set; }
        public int StateId { get; set; }

    }
}