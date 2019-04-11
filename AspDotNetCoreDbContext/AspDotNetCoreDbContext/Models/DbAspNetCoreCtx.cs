using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspDotNetCoreDbContext
{

    /// <summary>
    /// dotnet ef migrations add MXXX -c DbAspNetCoreCtx
    /// dotnet ef database update -c DbAspNetCoreCtx
    /// 
    /// 
    /// </summary>
    public class DbAspNetCoreCtx : DbContext
    {
        public DbAspNetCoreCtx(DbContextOptions<DbAspNetCoreCtx> options)
        : base(options)
        {
            Helper.CtxConstructor++;
        }

        public DbSet<Table1> Table1 { get; set; }



    }
}
