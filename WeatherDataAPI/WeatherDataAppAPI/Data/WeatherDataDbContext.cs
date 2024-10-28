using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WeatherDataAppAPI.Data;

public partial class WeatherDataDbContext : DbContext
{
    public WeatherDataDbContext()
    {
    }

    public WeatherDataDbContext(DbContextOptions<WeatherDataDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ExtLocation> ExtLocations { get; set; }

    public virtual DbSet<ExtUser> ExtUsers { get; set; }

    public virtual DbSet<ExtUserPreferredLocation> ExtUserPreferredLocations { get; set; }

    public virtual DbSet<ExtWeatherCurrent> ExtWeatherCurrents { get; set; }

    public virtual DbSet<ExtWeatherForecast> ExtWeatherForecasts { get; set; }

    public virtual DbSet<ExtWeatherHistorical> ExtWeatherHistoricals { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=ConnectionStrings:DefaultConnection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ExtLocation>(entity =>
        {
            entity.HasKey(e => e.LocationId).HasName("PK__ext_Loca__E7FEA4773984C160");

            entity.ToTable("ext_Locations");

            entity.Property(e => e.LocationId).HasColumnName("LocationID");
            entity.Property(e => e.City).HasMaxLength(100);
            entity.Property(e => e.Country).HasMaxLength(100);
            entity.Property(e => e.State).HasMaxLength(100);
        });

        modelBuilder.Entity<ExtUser>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__ext_User__1788CCAC8C473244");

            entity.ToTable("ext_Users");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.PasswordHash).HasMaxLength(255);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ExtUserPreferredLocation>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Location }).HasName("PK__ext_User__19DD1F1D1D894706");

            entity.ToTable("ext_UserPreferredLocations");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Location).HasMaxLength(50);

            entity.HasOne(d => d.User).WithMany(p => p.ExtUserPreferredLocations)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ext_UserP__UserI__02084FDA");
        });

        modelBuilder.Entity<ExtWeatherCurrent>(entity =>
        {
            entity.HasKey(e => e.WeatherId).HasName("PK__ext_Weat__0BF97BD5026BFA8A");

            entity.ToTable("ext_Weather_Current");

            entity.Property(e => e.WeatherId).HasColumnName("WeatherID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.WeatherDescription).HasMaxLength(255);
        });

        modelBuilder.Entity<ExtWeatherForecast>(entity =>
        {
            entity.HasKey(e => e.ForecastId).HasName("PK__ext_Weat__7F274458578529A4");

            entity.ToTable("ext_Weather_Forecasts");

            entity.Property(e => e.ForecastId).HasColumnName("ForecastID");
            entity.Property(e => e.Region).HasMaxLength(50);
            entity.Property(e => e.WeatherDescription).HasMaxLength(255);
        });

        modelBuilder.Entity<ExtWeatherHistorical>(entity =>
        {
            entity.HasKey(e => e.WeatherId).HasName("PK__ext_Weat__0BF97BD53D894B1D");

            entity.ToTable("ext_Weather_Historical");

            entity.Property(e => e.WeatherId).HasColumnName("WeatherID");
            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.Location).HasMaxLength(50);
            entity.Property(e => e.WeatherDescription).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
