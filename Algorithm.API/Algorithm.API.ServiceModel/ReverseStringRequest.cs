using ServiceStack;

namespace Algorithm.API.ServiceModel
{
	[Route("/reversestringrequest/{InputString}", "GET")]
	public class ReverseStringRequest : IReturn<ReverseStringResponseModel>
	{
		public string InputString { get; set; }
	}

	public class ReverseStringResponseModel
	{
		public string OutputString { get; set; }
	}
}
