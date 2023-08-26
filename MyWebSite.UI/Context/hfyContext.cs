using Microsoft.EntityFrameworkCore;
using MyWebSite.UI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWebSite.UI.Context
{
    public class hfyContext: DbContext
    {
        public hfyContext()
        {

        }
        public hfyContext(DbContextOptions opt) : base(opt)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-IH2SMGI;Database=MyWebSiteDB;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }

        public virtual DbSet<Iletisim> Iletisim { get; set; }
    }
}
