using Microsoft.Extensions.DependencyInjection;
using TextCore.Commands;
using TextCore.Factories;
using TextCore.Interfaces;
using TextCore.Repositories;
using TextCore.Repositories.Interfaces;


namespace TextApi.Extensions
{
    public static class ServiceExtensions
    {
		public static void AddCommands(this IServiceCollection services)
		{
			services.AddTransient<IGetUserInputCommand, GetUserInputCommand>();
			services.AddTransient<IGetTextFromFileCommand, GetTextFromFileCommand>();
			services.AddTransient<IGetTextsCommand, GetTexstsCommand>();
			services.AddTransient<IAddTextCommand, AddTextCommand>();
		}

		public static void AddRepositories(this IServiceCollection services)
		{
			services.AddScoped(typeof(ITextRepository), typeof(TextRepository));
		}

		public static void AddFacades(this IServiceCollection services)
		{
			services.AddTransient<ITextFacade, TextFacade>();
		}

	}
}
