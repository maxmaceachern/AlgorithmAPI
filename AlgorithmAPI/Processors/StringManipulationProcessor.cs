using Algorithm.API.ServiceModel;

namespace AlgorithmAPI.Processors
{
	public class StringManipulationProcessor
	{
		public ReverseStringResponseModel ReverseString (string request)
		{
			var word = request.ToCharArray();
			var i = 0;
			var j = request.Length - 1;
			while (i < j)
			{
				var temp = word[i];
				word[i] = word[j];
				word[j] = temp;
				i++;
				j--;
			}
			return new ReverseStringResponseModel { OutputString = new string(word) };
		}
	}
}
