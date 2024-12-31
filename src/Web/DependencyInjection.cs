using Web.Common.Models.Options;

namespace Web;

public static class DependencyInjection
{
    public static IServiceCollection AddWeb(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddModels(configuration);
        return services;
    }

    private static IServiceCollection AddModels(this IServiceCollection services, IConfiguration configuration)
    {
        var appSettingModel = configuration.GetSection(AppSettingModel.SectionName).Get<AppSettingModel>();
        ArgumentNullException.ThrowIfNull(appSettingModel);
        services.AddSingleton(appSettingModel);
        return services;
    }
}