using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DIIssue.EntityFrameworkCore;
using DIIssue.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace DIIssue.Web.Tests
{
    [DependsOn(
        typeof(DIIssueWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class DIIssueWebTestModule : AbpModule
    {
        public DIIssueWebTestModule(DIIssueEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(DIIssueWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(DIIssueWebMvcModule).Assembly);
        }
    }
}