using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Repository_Pattern.Database
{
    public class DataBaseContext : DbContext
    {

        public DataBaseContext(DbContextOptions options) : base(options)
        {
        }
    }
}
