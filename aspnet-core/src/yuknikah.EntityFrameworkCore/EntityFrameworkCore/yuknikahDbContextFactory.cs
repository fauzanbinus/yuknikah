using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using yuknikah.Configuration;
using yuknikah.Web;

namespace yuknikah.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class yuknikahDbContextFactory : IDesignTimeDbContextFactory<yuknikahDbContext>
    {
        public yuknikahDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<yuknikahDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            yuknikahDbContextConfigurer.Configure(builder, configuration.GetConnectionString(yuknikahConsts.ConnectionStringName));

            return new yuknikahDbContext(builder.Options);
        }
    }
}
