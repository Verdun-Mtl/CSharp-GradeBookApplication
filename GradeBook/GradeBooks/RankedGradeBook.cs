using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            int nrStdnts = Students.Count;
            if(nrStdnts < 5)
            {
                throw new InvalidOperationException();
            }            
            return 'F';
        }
    }
}
