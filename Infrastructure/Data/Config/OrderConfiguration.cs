using System;
using Core.Entities.OrderAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.OwnsOne(o => o.ShipToAddress, a => a.WithOwner());

            builder.Property(o => o.Status).HasConversion(
                s => s.ToString(),
                s => (OrderStatus) Enum.Parse(typeof(OrderStatus), s)
            );

            builder.HasMany(o => o.OrderItems).WithOne().OnDelete(DeleteBehavior.Cascade);

            builder.Property(o => o.Subtotal)
                .HasColumnType("decimal(18,2)");
        }
    }
}
