using System.Collections.Generic;

namespace RB_Soft.Infrastructure.Models
{
    public class ResultModel
    {
        public bool IsDone { get; set; }
        public ICollection<string> ErrorMessages { get; set; }

        public ResultModel(bool isDone = true) 
        {
            IsDone = isDone;
        }
    }
}
