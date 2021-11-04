using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4.Untitled
{
	public class Schedule
	{
		static DateTime Date { get; set; }
		string Event { get; set; }

		public Schedule(string appointment)
        {
			this.Event = appointment;
        }

		private string getSchedule()
		{
			throw new NotImplementedException();
		}

		private void deleteSchedule()
		{
			throw new NotImplementedException();
		}
	}
}
