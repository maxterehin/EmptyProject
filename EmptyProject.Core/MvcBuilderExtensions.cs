using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace EmptyProject.Core
{
    public static class MvcBuilderExtensions
    {
        public static IMvcBuilder AddCoreApplicationPart(this IMvcBuilder mvcBuilder)
        {
            mvcBuilder.AddApplicationPart(typeof(MvcBuilderExtensions).GetTypeInfo().Assembly);

            return mvcBuilder;
        }
    }
}
