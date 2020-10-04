using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name) : base(name)
        {
            this.Type = Enums.GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            // w tym miejscu test zgłasza błąd chodź na oko wszystko wydaje się być dobrze
            if (this.Students.Count < 5)
                throw new InvalidOperationException();

            if (averageGrade >= 80)
                return 'A';
            else if (averageGrade >= 60 && averageGrade < 80)
                return 'B';
            else if (averageGrade >= 40 && averageGrade < 60)
                return 'C';
            else if (averageGrade >= 20 && averageGrade < 40)
                return 'D';
            else return 'F';
        }
    }
}
