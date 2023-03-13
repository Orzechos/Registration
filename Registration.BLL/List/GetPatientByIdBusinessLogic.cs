using log4net;
using Registration.IBLL;
using Registration.IDAL.Repository;
using Registration.Model;
using System;

namespace Registration.BLL.List
{
    public class GetPatientByIdBusinessLogic : IGetPatientByIdBusinessLogic
    {
        private IPatientRepository _patientRepository;
        public GetPatientByIdBusinessLogic(ILog log, IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public PatientModel Process(Guid prop)
        {
            return _patientRepository.GetById(prop);
        }
    }
}
