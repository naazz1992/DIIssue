using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DIIssue.Configuration;

namespace DIIssue.Web.Host.Startup
{
    [DependsOn(
       typeof(DIIssueWebCoreModule))]
    public class DIIssueWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public DIIssueWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DIIssueWebHostModule).GetAssembly());
        }
    }
}
