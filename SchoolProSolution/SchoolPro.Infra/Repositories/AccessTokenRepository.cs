using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPro.Infra.Repositories
{
    public class AccessTokenRepository : RepositoryBase<AccessToken>, IAccessTokenRepository
    {
        public AccessTokenRepository([NotNull] SchoolProDbContext context) : base(context)
        {
        }
    }
}
