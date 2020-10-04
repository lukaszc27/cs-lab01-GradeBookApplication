using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name, bool isWeight) : base(name, isWeight)
        {
            this.Type = Enums.GradeBookType.Standard;
        }
    }
}
