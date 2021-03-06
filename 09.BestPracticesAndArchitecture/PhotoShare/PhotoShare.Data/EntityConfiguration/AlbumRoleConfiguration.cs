﻿namespace PhotoShare.Data.EntityConfiguration
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;

    internal class AlbumRoleConfiguration : IEntityTypeConfiguration<AlbumRole>
    {
        public void Configure(EntityTypeBuilder<AlbumRole> builder)
        {
            builder.HasKey(e => new { e.AlbumId, e.UserId });

            builder.HasOne(e => e.User)
                .WithMany(u => u.AlbumRoles)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.Album)
                .WithMany(a => a.AlbumRoles)
                .HasForeignKey(e => e.AlbumId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}