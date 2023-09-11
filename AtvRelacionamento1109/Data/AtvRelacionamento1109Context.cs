using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AtvRelacionamento1109.Models;

namespace AtvRelacionamento1109.Data
{
    public class AtvRelacionamento1109Context : DbContext
    {
        public AtvRelacionamento1109Context (DbContextOptions<AtvRelacionamento1109Context> options)
            : base(options)
        {
        }

        public DbSet<AtvRelacionamento1109.Models.Estoque> Estoque { get; set; } = default!;
    }
}
