using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandardGradBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}