using Newtonsoft.Json;

namespace GeneticAlgorithm.Models.Extensions
{
	public static class CloningExtensions
	{
		public static T Clone<T>(this T source)
		{            
			// Don't serialize a null object, simply return the default for that object
			if (ReferenceEquals(source, null))
			{
				return default!;
			}

			// Initialize inner objects individually
			// for example in default constructor some list property initialized with some values,
			// but in 'source' these items are cleaned -
			// without ObjectCreationHandling.Replace default constructor values will be added to result
			var deserializeSettings = new JsonSerializerSettings {ObjectCreationHandling = ObjectCreationHandling.Replace};

			return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(source), deserializeSettings)!;
		}
	}
}