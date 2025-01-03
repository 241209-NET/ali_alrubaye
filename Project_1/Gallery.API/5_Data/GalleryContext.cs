using Gallery.API.Model;
using Microsoft.EntityFrameworkCore;

namespace Gallery.API.Data;

public class GalleryContext : DbContext{

    public GalleryContext(){}
    public GalleryContext(DbContextOptions<GalleryContext> options) : base(options){}
    
    public DbSet<User> User {get;set;}
    public DbSet<Painting> Painting {get;set;}
}