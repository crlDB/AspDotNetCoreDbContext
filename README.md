# AspDotNetCoreDbContext

## Connectionstring - appsettings.json

```
  "ConnectionStrings": {
    "AspDotNetCoreDB": "Server=.\\SQLEXPRESS;Database=asp_net_core_db;MultipleActiveResultSets=true;User Id=sa;Password=XXX"
  }
```

## DbContext - DbAspNetCoreCts.cs

## DbSet - Table1.cs / Table2.cs 

## DI - startup.cs
```
    // database
    services.AddDbContext<DbAspNetCoreCtx>(options =>
            options.UseSqlServer(configuration.GetConnectionString("AspDotNetCoreDB")));

```

## add ef migrations 
> dotnet ef migrations add MXXX -c DbAspNetCoreCtx

```
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AspDotNetCoreDbContext.Migrations
{
    public partial class M100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Table1",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    String1 = table.Column<string>(maxLength: 50, nullable: true),
                    Num1 = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table1");
        }
    }
}
```

## update ef migrations
> dotnet ef database update -c DbAspNetCoreCtx



## IMPORTANT

>Cannot access a disposed object. A common cause of this error is disposing a context that was resolved from dependency injection and then later trying to use the same context instance elsewhere in your application. This may occur if you are calling Dispose() on the context, or wrapping the context in a using statement. If you are using dependency injection, you should let the dependency injection container take care of disposing context instances.

see layer1.cs  > CreateRec
