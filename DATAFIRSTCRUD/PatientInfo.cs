namespace DATAFIRSTCRUD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PatientInfo
    {
        public int PatientINfoId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public int PhoneNO { get; set; }

        public string Address { get; set; }

        public string Email { get; set; }
    }
}
