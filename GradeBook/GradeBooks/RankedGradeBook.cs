using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException(message:"Not enough students!");
            }

            // Figure out how many students it takes to drop a letter grade (20% of the total number of students)
            // Put all the average grades in order, then figure out where the input grade would fit in the series of grades
            // Every X students with higher grades than the input grade knocks the letter grade down until you reach F.

            return 'F';
        }
    }
}
