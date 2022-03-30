using System;

namespace Delegate.Models
{
	public class Medicine
	{
        public int Id { get; }
		private static int _id;
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
		public bool isDeleted = false;

        public Medicine(int Id, int _id)
		{
            _id++;
			Id = _id;
		}

        public int Sell(int Count)
        {
            return Count--;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id{_id}\n Name{Name}\n Price{Price}\n Count{Count}\n Deleted {isDeleted}");
        }


	}
}

