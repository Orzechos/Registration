using Registration.DB;
using Registration.IDAL.Repository;
using Registration.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Registration.DAL.Repository
{
    public class PatientRepository : DbContext, IPatientRepository
    {
        public DbSet<PatientDB> Patients { get; set; }


        public PatientRepository() : base("RegistrationConnectionString")
        {
            this.Configuration.AutoDetectChangesEnabled = false;
        }

        public IEnumerable<PatientModel> GetAll()
        {
            return Patients.Select(p => new PatientModel()
            {
                Id = p.Id,
                Name = p.Name,
                Surname = p.Surname,
                PhoneNumber = p.PhoneNumber,
                LastModificationDate = p.LastModificationDate,
                LastModificationBy = p.LastModificationBy,
                Address = p.Address,
                CreationBy = p.CreationBy,
                CreationDate = p.CreationDate,
                Email = p.Email,
                Pesel = p.Pesel
            });
        }

        public PatientModel GetById(Guid id)
        {
            return Map(Patients.SingleOrDefault(i=> i.Id == id));
        }

        public void AddOrUpdate(PatientModel model)
        {
            PatientDB patientDB = Map(model);
            Patients.AddOrUpdate(patientDB);
            SaveChanges();            
        }

        public void RemoveById(Guid Id)
        {
            PatientDB patientDB = Patients.SingleOrDefault(i=> i.Id==Id);
            Patients.Remove(patientDB);
            SaveChanges();
        }

        private PatientDB Map(PatientModel patientModel)
        {
            return new PatientDB()
            {
                Id = patientModel.Id,
                Name = patientModel.Name,
                Surname = patientModel.Surname,
                Pesel = patientModel.Pesel,
                Address = patientModel.Address,
                CreationBy = patientModel.CreationBy,
                CreationDate = patientModel.CreationDate,
                Email = patientModel.Email,
                LastModificationBy = patientModel.LastModificationBy,
                LastModificationDate = patientModel.LastModificationDate,
                PhoneNumber = patientModel.PhoneNumber,
            };
        }

        private PatientModel Map(PatientDB patientDB)
        {
            return new PatientModel()
            {
                Id = patientDB.Id,
                Name = patientDB.Name,
                Surname= patientDB.Surname,
                PhoneNumber= patientDB.PhoneNumber,
                LastModificationDate= patientDB.LastModificationDate,
                LastModificationBy= patientDB.LastModificationBy,   
                Address= patientDB.Address,
                CreationBy= patientDB.CreationBy,
                CreationDate = patientDB.CreationDate,
                Email= patientDB.Email,
                Pesel = patientDB.Pesel               
            };
        }

    }
}
