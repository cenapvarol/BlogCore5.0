using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{

    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-PSVTSLG\\SQLEXPRESS;database=CoreBlogDb; integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Message2>()
                .HasOne(x => x.SenderUser)
                .WithMany(y => y.WriterSender)
                .HasForeignKey(z => z.SenderID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Message2>()
                .HasOne(x => x.ReceiverUser)
                .WithMany(y => y.WritreReceiver)
                .HasForeignKey(z => z.ReceiverID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<NewsLetter> NewsLetters { get; set; }
        public DbSet<BlogRayting> blogRaytings { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Message> messages { get; set; }
        public DbSet<Message2> message2s { get; set; }
    }

    //Migiration işlemi yapılma aşaması   Microsoft Visual Studio uygulmasında üst kısımda bulunan View sekmesine tıklıyoruz karşımıza gelen ekranda  Other Windows sekmesinde Package Manager Console'a
    // basıyoruz karşımıza paket yükleme konsolu gelecek  gelen konsola  add-migration mig1  şeklinde komut yazılır komut çalıştırıldığında sonra DataAccessLayer Katmanında Migrations klasörü oluşur 
    //Bu işlemin ardında yapılan işlemlerin veritabanı tarafında yansıya bilmesi için   ( update-database ) komut çalıştırılır  komut düzgün çalıştığını kontrol etmek için sql server tarafında konreol edilir.
}
