namespace Lab3;

/* Benjamin Wastart
 * October 8, 2022
 * Description: A .Net-Maui app that connects to a database of Crossword questions. You can sort, update, create, or delete entries.
 * Bugs: None that I know of.
 * Reflection: Made me feel great when I was able to change the online database from the app. Not too hard of a project.
 * Took awhile to fix errors to allow database to change.
 * 
 */
public static class MauiProgram
{
    public static IBusinessLogic ibl = new BusinessLogic();

    public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		return builder.Build();
	}
}

