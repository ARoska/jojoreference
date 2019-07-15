using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JojoRef.Data
{
    public class JojoDbContext : DbContext
    {
        public JojoDbContext(DbContextOptions<JojoDbContext> options) : base(options)
        {
        }
    }
}
