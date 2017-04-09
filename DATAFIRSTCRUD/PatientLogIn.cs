namespace DATAFIRSTCRUD
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PatientLogIn
    {
        public int PatientLogInId { get; set; }

        public int PatientINfoId { get; set; }

        public string PatientName { get; set; }

        public int Password { get; set; }
    }
}
