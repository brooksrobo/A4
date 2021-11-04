using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4.Untitled
{
	public class Faculty
	{
		static int ID { get; set; }
		string contact { get; set; }
		string name;

		public Faculty(string name)
        {
			this.name = name;
        }

		public string Name
		{
			get { return name; }

			set

			{
				if (string.IsNullOrWhiteSpace(value))
				{
					throw new Exception("Name required.");
				}
				if (name != null)
				{
					Console.WriteLine("Changing name from " + name);
					Console.WriteLine("to " + value);
				}
				name = value;
			}
		}

		private string Contact()
		{
			throw new NotImplementedException();
		}
	}
}
