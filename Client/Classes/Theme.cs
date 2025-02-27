using MudBlazor;

namespace Client.Classes;

public class Themes
{
	public static readonly MudTheme MyTheme = new()
	{
		PaletteLight = new PaletteLight()
		{
			Black = "rgba(10, 10, 10, 1)",
			White = "rgba(248, 249, 250, 1)",
			Background = "rgba(10, 10, 10, 1)",
			DrawerBackground = "rgba(37, 36, 34, 1)",
			DrawerText = "rgba(248, 249, 250, 1)",
			DrawerIcon = "rgba(248, 249, 250, 1)",
			AppbarBackground = "rgba(10, 10, 10, 1)",
			AppbarText = "rgba(248, 249, 250, 1)",
			TextPrimary = "rgba(248, 249, 250, 1)",
			Dark = "rgba(10, 10, 10, 1)"
		}
	};
}