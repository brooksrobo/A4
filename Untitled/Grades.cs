using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4.Untitled
{
	public class Grades
	{
		static int studentID;
		string gradeLetter { get; set; }
		int gradePercent { get; set; }

		public Grades(int percent)
        {
			this.gradePercent = percent;
        }
		
		public Grades(string letter, int percent)
        {
            this.gradeLetter = letter;
			this.gradePercent = percent;
        }
		private int getPercent()
		{
			throw new NotImplementedException();
		}

		private string getLetter()
		{
			throw new NotImplementedException();
		}

		private int setPercent()
		{
			throw new NotImplementedException();
		}
	}
}
