using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADGL_Blazor.DataAccess.Data
{
    public class ADGL_BlazorContext:DbContext
    {
        public ADGL_BlazorContext(DbContextOptions<ADGL_BlazorContext> options):base(options)
        {

        }

        public DbSet<Course> Courses { get; set; }
    }
}
