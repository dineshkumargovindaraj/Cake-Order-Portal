namespace CakeOrderPortal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CakeDeliveryModel : DbContext
    {
        public CakeDeliveryModel()
            : base("name=CakeDeliveryModel")
        {
        }

        public virtual DbSet<CakeOrderDetail> CakeOrderDetails { get; set; }
        public virtual DbSet<PaymentInformation> PaymentInformations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.CakeName);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.CakeType)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.Weight)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.StreetNumber)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.Province)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<CakeOrderDetail>()
                .Property(e => e.PostalCode)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInformation>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInformation>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInformation>()
                .Property(e => e.CreditCardType)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInformation>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<PaymentInformation>()
                .Property(e => e.CreditCardNumber)
                .IsUnicode(false);
        }
    }
}
