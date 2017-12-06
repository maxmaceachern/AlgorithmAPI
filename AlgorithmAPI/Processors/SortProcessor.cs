namespace AlgorithmAPI
{
    public class SortProcessor
    {
		public int[] BubbleSort(int[] request)
		{
			int temp = 0;

			for (int i = 0; i < request.Length; i++)
			{
				for (int j = 0; j < request.Length - 1; j++)
				{
					if (request[j] > request[j + 1])
					{
						temp = request[j + 1];
						request[j + 1] = request[j];
						request[j] = temp;
					}
				}
			}

			return request;
		}
    }
}
