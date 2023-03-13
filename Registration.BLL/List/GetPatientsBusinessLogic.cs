using log4net;
using Registration.IBLL;
using Registration.IDAL.Repository;
using Registration.Model;
using System.Collections.Generic;
using System.Linq;

namespace Registration.BLL.List
{
    public class GetPatientsBusinessLogic : IGetPatientsBusinessLogic
    {

        private IPatientRepository _patientRepository;
        public GetPatientsBusinessLogic(ILog log, IPatientRepository patientRepository) { 
            _patientRepository = patientRepository;
        }

        public IEnumerable<PatientModel> Process()
        {
            return _patientRepository.GetAll().ToList();
        }
    }
}
