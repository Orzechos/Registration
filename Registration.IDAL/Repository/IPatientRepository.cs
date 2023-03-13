using Registration.Model;
using System;
using System.Collections.Generic;

namespace Registration.IDAL.Repository
{
    public interface IPatientRepository
    {
        IEnumerable<PatientModel> GetAll();

        PatientModel GetById(Guid id);

        void AddOrUpdate(PatientModel model);

        void RemoveById(Guid Id);
    }
}
