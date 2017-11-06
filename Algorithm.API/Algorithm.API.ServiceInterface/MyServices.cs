using ServiceStack;
using Algorithm.API.ServiceModel;
using AlgorithmAPI;

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
	}
}