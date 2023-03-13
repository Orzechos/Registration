using log4net;
using Registration.Model;
using Registration.IBLL;
using Registration.IDAL.Repository;
using System;

namespace Registration.BLL.List
{
    public class RemovePatientByIdBusinessLogic: IRemovePatientByIdBusinessLogic
    {
        private IPatientRepository _patientRepository;
        public RemovePatientByIdBusinessLogic(ILog log, IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public bool Process(Guid prop)
        {
            PatientModel patientModel = _patientRepository.GetById(prop);
            
            if(patientModel == null) {
                throw new Exception($"Can't find the patient. Id: {prop}");
            }
            else
            {
                _patientRepository.RemoveById(patientModel.Id);
            }

            return true;
        }
    }
}
