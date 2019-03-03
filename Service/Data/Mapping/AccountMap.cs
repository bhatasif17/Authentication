using DTO;
using System.Data.Entity.ModelConfiguration;

namespace Service.Data.Mapping
{
    public class AccountMap : EntityTypeConfiguration<Account>
    {
        public AccountMap()
        {
            this.ToTable("Account");
            this.HasKey(a => a.Id);
        }
    }
}