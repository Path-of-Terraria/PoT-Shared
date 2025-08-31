namespace PoTSharedModules.Models;

public enum TradeListingCurrency
{
	DO_NOT_USE = 0,
	UnfoldingShard = 1,
	GlimmeringShard = 2,
	LimpidShard = 3,
	RadiantShard = 4,
	EchoingShard = 5,
	CorruptShard = 6,
	ShiftingShard = 7,
	MysticShard = 8,
}

public class TradeListingCurrencyExtensions
{
	public static string GetFriendlyName(TradeListingCurrency currency)
	{
		string? enumName = Enum.GetName(typeof(TradeListingCurrency), currency);

		if (enumName != null)
		{
			return System.Text.RegularExpressions.Regex.Replace(enumName, "([a-z])([A-Z])", "$1 $2");
		}
		
		return $"FAILED TO CONVERT - {currency}";
	}
}