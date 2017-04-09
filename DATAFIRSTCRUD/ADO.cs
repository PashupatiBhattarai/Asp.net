namespace DATAFIRSTCRUD
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ADO : DbContext
    {
        public ADO()
            : base("name=CRUD")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<PatientInfo> PatientInfoes { get; set; }
        public virtual DbSet<PatientLogIn> PatientLogIns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
