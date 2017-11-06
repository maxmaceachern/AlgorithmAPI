using ServiceStack;

namespace Algorithm.API.ServiceModel
{
	[Route("/bubblesortrequest/{InputArray}", "GET")]
	public class BubbleSortRequest : IReturn<BubbleSortResponseModel>
	{
		public int[] InputArray { get; set; }
	}

	public class BubbleSortResponseModel
	{
		public int[] OutputArray { get; set; }
	}
}
