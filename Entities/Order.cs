using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace post_office.Entities
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Code { get; set; }

        public double Length { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
        public double Weight { get; set; }

        public int SenderId { get; set; }
        public string SenderFirstName { get; set; }
        public string SenderLastName { get; set; }
        public string SenderEmail { get; set; }
        public string SenderPhone { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhone { get; set; }
        public string FromAddress { get; set; }
        public int FromWardId { get; set; }
        public int FromCityId { get; set; }
        public int FromProvinceId { get; set; }

        public int? ReceiverId { get; set; }
        public string ReceiverFirstName { get; set; }
        public string ReceiverLastName { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverPhone { get; set; }
        public string ToAddress { get; set; }
        public int ToWardId { get; set; }
        public int ToCityId { get; set; }
        public int ToProvinceId { get; set; }
        public string PinCode { get; set; }

        public int DeliveryStatus { get; set; }
        public decimal DeliveryFee { get; set; }
        public DateTime? DeliveryOn { get; set; }

        public decimal? CollectAmount { get; set; }
        public string Notes { get; set; }
        public int Status { get; set; }
        public DateTime? CreatedAt { get; set; }

        public Customer Receiver { get; set; }
        public Customer Sender { get; set; }
        
        public VNWard FromWard { get; set; }
        public VNWard ToWard { get; set; }
        public VNCity FromCity { get; set; }
        public VNCity ToCity { get; set; }
        public VNState FromProvince { get; set; }
        public VNState ToProvince { get; set; }
    }
}