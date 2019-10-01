namespace ScienceConferenceApp.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbAppContext : DbContext
    {
        public DbAppContext()
            : base("name=DbAppContext")
        {
        }

        public virtual DbSet<car> cars { get; set; }
        public virtual DbSet<carType> carTypes { get; set; }
        public virtual DbSet<colour> colours { get; set; }
        public virtual DbSet<engine> engines { get; set; }
        public virtual DbSet<engineType> engineTypes { get; set; }
        public virtual DbSet<manualTransmission> manualTransmissions { get; set; }
        public virtual DbSet<manufacturer> manufacturers { get; set; }
        public virtual DbSet<merchandise> merchandises { get; set; }
        public virtual DbSet<model> models { get; set; }
        public virtual DbSet<orderDetail> orderDetails { get; set; }
        public virtual DbSet<order> orders { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<status> statuses { get; set; }
        public virtual DbSet<transmission> transmissions { get; set; }
        public virtual DbSet<user> users { get; set; }
        public virtual DbSet<ViewCar> ViewCars { get; set; }
        public virtual DbSet<ViewEngineCar> ViewEngineCars { get; set; }
        public virtual DbSet<ViewManufacturerCar> ViewManufacturerCars { get; set; }
        public virtual DbSet<ViewOrderDetail> ViewOrderDetails { get; set; }
        public virtual DbSet<ViewTransmissionCar> ViewTransmissionCars { get; set; }
        public virtual DbSet<ViewUser> ViewUsers { get; set; }
        public virtual DbSet<ViewUserOrder> ViewUserOrders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<car>()
                .HasMany(e => e.merchandises)
                .WithRequired(e => e.car1)
                .HasForeignKey(e => e.car)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<carType>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<carType>()
                .HasMany(e => e.models)
                .WithOptional(e => e.carType)
                .HasForeignKey(e => e.type);

            modelBuilder.Entity<colour>()
                .Property(e => e.colourName)
                .IsUnicode(false);

            modelBuilder.Entity<colour>()
                .HasMany(e => e.models)
                .WithOptional(e => e.colour1)
                .HasForeignKey(e => e.colour);

            modelBuilder.Entity<engine>()
                .Property(e => e.engine1)
                .IsUnicode(false);

            modelBuilder.Entity<engine>()
                .HasMany(e => e.models)
                .WithOptional(e => e.engine1)
                .HasForeignKey(e => e.engine);

            modelBuilder.Entity<engineType>()
                .Property(e => e.engineType1)
                .IsUnicode(false);

            modelBuilder.Entity<engineType>()
                .HasMany(e => e.engines)
                .WithOptional(e => e.engineType1)
                .HasForeignKey(e => e.engineType);

            modelBuilder.Entity<manualTransmission>()
                .Property(e => e.manualTrans)
                .IsUnicode(false);

            modelBuilder.Entity<manualTransmission>()
                .HasMany(e => e.transmissions)
                .WithRequired(e => e.manualTransmission)
                .HasForeignKey(e => e.manualTrans)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manufacturer>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<manufacturer>()
                .HasMany(e => e.cars)
                .WithRequired(e => e.manufacturer1)
                .HasForeignKey(e => e.manufacturer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<manufacturer>()
                .HasMany(e => e.models)
                .WithOptional(e => e.manufacturer1)
                .HasForeignKey(e => e.manufacturer);

            modelBuilder.Entity<merchandise>()
                .HasMany(e => e.orderDetails)
                .WithRequired(e => e.merchandise1)
                .HasForeignKey(e => e.merchandise)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<model>()
                .Property(e => e.model1)
                .IsUnicode(false);

            modelBuilder.Entity<model>()
                .HasMany(e => e.cars)
                .WithOptional(e => e.model1)
                .HasForeignKey(e => e.model);

            modelBuilder.Entity<orderDetail>()
                .Property(e => e.approved)
                .IsUnicode(false);

            modelBuilder.Entity<order>()
                .HasMany(e => e.orderDetails)
                .WithRequired(e => e.order1)
                .HasForeignKey(e => e.order)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .Property(e => e.role1)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithOptional(e => e.role)
                .HasForeignKey(e => e.sysRole);

            modelBuilder.Entity<status>()
                .Property(e => e.status1)
                .IsUnicode(false);

            modelBuilder.Entity<status>()
                .HasMany(e => e.users)
                .WithOptional(e => e.status1)
                .HasForeignKey(e => e.status);

            modelBuilder.Entity<transmission>()
                .Property(e => e.autoTrans)
                .IsUnicode(false);

            modelBuilder.Entity<transmission>()
                .HasMany(e => e.models)
                .WithOptional(e => e.transmission1)
                .HasForeignKey(e => e.transmission);

            modelBuilder.Entity<user>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.secondName)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.orders)
                .WithRequired(e => e.user)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.engine)
                .IsUnicode(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.type)
                .IsUnicode(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.manualTrans)
                .IsUnicode(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.autoTrans)
                .IsUnicode(false);

            modelBuilder.Entity<ViewCar>()
                .Property(e => e.colourName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewEngineCar>()
                .Property(e => e.engine)
                .IsUnicode(false);

            modelBuilder.Entity<ViewEngineCar>()
                .Property(e => e.engineType)
                .IsUnicode(false);

            modelBuilder.Entity<ViewManufacturerCar>()
                .Property(e => e.company)
                .IsUnicode(false);

            modelBuilder.Entity<ViewManufacturerCar>()
                .Property(e => e.model)
                .IsUnicode(false);

            modelBuilder.Entity<ViewOrderDetail>()
                .Property(e => e.approved)
                .IsUnicode(false);

            modelBuilder.Entity<ViewTransmissionCar>()
                .Property(e => e.autoTrans)
                .IsUnicode(false);

            modelBuilder.Entity<ViewTransmissionCar>()
                .Property(e => e.manualTrans)
                .IsUnicode(false);

            modelBuilder.Entity<ViewUser>()
                .Property(e => e.role)
                .IsUnicode(false);

            modelBuilder.Entity<ViewUser>()
                .Property(e => e.firstName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewUser>()
                .Property(e => e.secondName)
                .IsUnicode(false);

            modelBuilder.Entity<ViewUser>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<ViewUser>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<ViewUser>()
                .Property(e => e.status)
                .IsUnicode(false);
        }
    }
}
