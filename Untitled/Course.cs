using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4.Untitled
{
	public class Course
	{
		int courseID { get; set; } 
		static string courseName { get; set; }
		int preReq { get; set; }

		public Course (int ID)
        {
			this.courseID = ID;
        }

		private void regCourse()
		{
			throw new NotImplementedException();
		}

		private void dropCourse()
		{
			throw new NotImplementedException();
		}

		private void getCourse()
		{
			throw new NotImplementedException();
		}

		private string waitlistCourse()
		{
			throw new NotImplementedException();
		}

		private string checkWaitlist()
		{
			throw new NotImplementedException();
		}
	}
}
