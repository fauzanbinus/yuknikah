using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using yuknikah.Configuration;

namespace yuknikah.Web.Host.Startup
{
    [DependsOn(
       typeof(yuknikahWebCoreModule))]
    public class yuknikahWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public yuknikahWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(yuknikahWebHostModule).GetAssembly());
        }
    }
}
