using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace post_office.Entities
{
    public class DataContext : DbContext
    {
        public static string _dbConnection;

        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            
        }

        //Customer
        public DbSet<Customer> Customers { get; set; }

        //Service
        public DbSet<Service> Services { get; set; }

        //Role - Permission - RolePermission
        public DbSet<RolePermission> RolePermissions { get; set; }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<PinCode> PinCodes { get; set; }

        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        
        //Contact - User
        public DbSet<Contact> Contacts { get; set; }

        //ProductPhoto - Attribute - ProductAttribute - ProductCategory - Product
        public DbSet<ProductPhoto> ProductPhotos { get; set; }

        //ProductBillDetail
        public DbSet<ProductBillDetail> ProductBillDetails { get; set; }

        //Order - OrderDetail - OrderDetailPhoto
        public DbSet<OrderDetailPhoto> OrderDetailPhotos { get; set; }
        
        //OrderTracking
        public DbSet<OrderTracking> OrderTrackings { get; set; }

        //Bill - BillOrder
        public DbSet<BillOrder> BillOrders { get; set; }

    }
}