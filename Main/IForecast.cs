using System.Threading.Tasks;

namespace Accuweather.Forecast
{
	/// <summary>
	/// Get forecast information for a specific location..
	/// </summary>
	public interface IForecast
	{
		/// <summary>
		/// Returns an array of daily forecasts for the next 5 days for a specific location.
		/// Forecast searches require a location key.
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="metric">Boolean value specifies whether or not to display metric values.</param>
		/// <returns></returns>
		Task<string> FiveDaysOfDailyForecasts(int locationKey, bool details = false,
		 bool metric = false);

		/// <summary>
		/// Returns an array of hourly forecasts for the next 12 hours for a specific location.
		/// Forecast searches require a location key. 
		/// </summary>
		/// <param name="locationKey">Unique ID to search for a specific location.</param>
		/// <param name="details">Boolean value specifies whether or not to include full details in the response.</param>
		/// <param name="metric">Boolean value specifies whether or not to display metric values.</param>
		/// <returns></returns>
		Task<string> TwelveHoursOfHourlyForecasts(int locationKey, bool details = false,
		bool metric = false);
	}
}
