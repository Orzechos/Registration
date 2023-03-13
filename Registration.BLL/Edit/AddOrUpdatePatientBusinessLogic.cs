using Registration.IBLL;
using Registration.IDAL.Repository;
using Registration.Model;

namespace Registration.BLL.Edit
{
    public class AddOrUpdatePatientBusinessLogic : IAddOrUpdatePatientBusinessLogic
    {
        private IPatientRepository _patientRepository;


        public AddOrUpdatePatientBusinessLogic(IPatientRepository patientRepository)
        {
            _patientRepository = patientRepository;
        }   

        public bool Process(PatientModel prop)
        {
            if(prop.Id == System.Guid.Empty)
            {
                prop.Id = System.Guid.NewGuid();
            }

            _patientRepository.AddOrUpdate(prop);
            return true;
        }
    }
}
