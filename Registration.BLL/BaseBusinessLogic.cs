using Registration.BLL;
using System.Collections.Generic;

namespace Registration.BLL
{
    public abstract class BaseBusinessLogic
    {
        protected List<IValidator> Validators { get; set; }

        public BaseBusinessLogic()
        {
            Validators = new List<IValidator>();
        }
    }
}
