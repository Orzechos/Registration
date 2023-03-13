using log4net;
using System.Collections.Generic;

namespace Registration.BLL
{
    public abstract class BaseBusinessLogic
    {
        protected readonly ILog _log;
        protected List<IValidator> Validators { get; set; }

        public BaseBusinessLogic(ILog log)
        {
            _log = log;
            Validators = new List<IValidator>();
        }
    }
}
