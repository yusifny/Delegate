using System;
using System.Collections.Generic;
using Delegate.Exceptions;

namespace Delegate.Models
{
	public class Pharmacy
	{
        public int MedicineLimit { get; set; }

        public List<Medicine> Medicines = new List<Medicine>();
		public void AddMedicine(Medicine medicine)
        {
           Medicine medicine1 = Medicines.Find(m=>m.Name==medicine.Name);

            if (medicine1!=null)
            {
                throw new MedicineAlreadyExistsException("Məhsul artır mövcuddur.");
            }
        }
	}
}

