using Accuweather.Core.Helpers;
using Accuweather.Core;
using System.Threading.Tasks;

namespace Accuweather.Forecast
{
	/// <summary>
	///	Accuweather Forecast Api
	/// </summary>
	public class Forecast : AccuweatherApiCore, IForecast
	{
		private const string _baseUrl = "http://dataservice.accuweather.com/forecasts/v1";

		/// <summary>
		/// 
		/// </summary>
		/// <param name="apiKey">Api key accuweather.</param>
		/// <param name="language">Language.</param>
		/// <returns></returns>
		public Forecast(string apiKey, string language = "en-us") : base(apiKey, language)
		{

		}
		private object GetObjectForecasts(bool details, bool metric)
		{
			return new {
				language = _language,
				details,
				metric
			};
		}
		public async Task<string> FiveDaysOfDailyForecasts(int locationKey, bool details = false,
		 bool metric = false)
		{
			var obj = GetObjectForecasts(details, metric);
			var url = $"{_baseUrl}/daily/5day/{locationKey}?apikey={_apiKey}&";

			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}

		public async Task<string> TwelveHoursOfHourlyForecasts(int locationKey, bool details = false,
		 bool metric = false)
		{
			var obj = GetObjectForecasts(details, metric);
			var url = $"{_baseUrl}/hourly/12hour/{locationKey}?apikey={_apiKey}&";

			return await SendGetRequest(UrlEncodeHelper.UrlEncode(obj, url));
		}		
	}
}