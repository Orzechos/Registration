using Registration.Model;
using System;

namespace Registration.IBLL
{
    public interface IGetPatientByIdBusinessLogic:IBaseBusinessLogic<PatientModel, Guid>
    {
    }
}
