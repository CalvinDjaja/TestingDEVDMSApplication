using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using TestingDEVDMSApplication.Entity;

namespace TestingDEVDMSApplication.Context
{
    public class DmsDbContext : DbContext
    {
        private readonly string _connectionString;

        public DmsDbContext(DbContextOptions<DmsDbContext> options) : base(options)
        {

        }

        public SqlConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<OwnershipOfResidence> OwnershipOfResidences { get; set; }
        public DbSet<CompanyCategory> CompanyCategorys { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<RecordPaymentTrack> RecordPaymentTracks { get; set; }
        public DbSet<TrackDataSLIK> TrackDataSLIKs { get; set; }
        public DbSet<PemilikanKartuKredit> PemilikanKartuKredits { get; set; }
        public DbSet<TujuanDariPembiayaan> TujuanDariPembiayaans { get; set; }
    }
}
