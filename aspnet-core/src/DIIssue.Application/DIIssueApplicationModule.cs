using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using DIIssue.Authorization;

namespace DIIssue
{
    [DependsOn(
        typeof(DIIssueCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DIIssueApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DIIssueAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DIIssueApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
