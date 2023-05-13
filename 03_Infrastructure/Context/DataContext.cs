using Microsoft.EntityFrameworkCore;
using proyecto_2ev_practicas;

public class DataContext : DbContext{
    public DataContext(DbContextOptions<DataContext> options) : base(options){ }

    public DbSet<ProductRepositoryModel>? Products {get;set;}
    // public DbSet<UserRepositoryModel>? Users {get;set;}
    public DbSet<OrderRepositoryModel>? Orders {get;set;}
    // public DbSet<ShopRepositoryModel>? Shops {get;set;}

}