using Microsoft.Extensions.DependencyInjection;
using QuestPDF.Infrastructure;

namespace BlazorPdfGeneration;

public static class DependencyInjection
{
	public static IServiceCollection AddBlazorPdfGeneration(this IServiceCollection services)
	{
		QuestPDF.Settings.License = LicenseType.Community;
		return services;
	}
}
