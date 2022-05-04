using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace cateringdemosample.Models
{
    public class EcomCategory
    {
        public int id { get; set; }
        public string name { get; set; }
        public string desc { get; set; }
        public string photopath { get; set; }
    }
    public class Food
    {
        public int id { get; set; }
        public string name { get; set; }
        [ForeignKey("categ")]
        public int categid { get; set; }
        public EcomCategory categ { get; set; }
        public string desc { get; set; }
        public string photopath { get; set; }
        public bool check { get; set; }
    }
    public class CateringContext : DbContext
    {
        public CateringContext(DbContextOptions<CateringContext> options) : base(options)
        {

        }
        public DbSet<EcomCategory> EcomCategory { get; set; }
        public DbSet<Food> foods { get; set; }
    }
}

