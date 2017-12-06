using ServiceStack;
using Algorithm.API.ServiceModel;
using AlgorithmAPI;
using AlgorithmAPI.Processors;

namespace Algorithm.API.ServiceInterface
{
	public class MyServices : Service
	{
		public object Any(BubbleSortRequest request)
		{
			//TODO Interface
			var _sortProcessor = new SortProcessor();
			return _sortProcessor.BubbleSort(request.InputArray);
		}

		public ReverseStringResponseModel Any(ReverseStringRequest request)
		{
			//TODO Interface
			var _stringManipulationProcessor = new StringManipulationProcessor();
			return _stringManipulationProcessor.ReverseString(request.InputString);
		}
	}
}