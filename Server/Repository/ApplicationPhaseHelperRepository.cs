using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.IRepository;
using Server.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using XebecPortal.Shared;
using XebecPortal.Shared.Security;

namespace Server.Repository
{
    public class ApplicationPhaseHelperRepository : GenericRepository<ApplicationPhaseHelper>, IApplicationPhaseHelperRepository
    {
        public ApplicationPhaseHelperRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<List<ApplicationPhaseHelper>> GetApplicationPhaseInfo(int AppUserId)
        {
            IQueryable<ApplicationPhaseHelper> queryFinal;
            //var job = new SqlParameter("jobId", JobId);
            //IQueryable<PersonalInformation> queryFinal = _context.PersonalInformations.
            //    FromSqlRaw("SELECT * from PersonalInformations Where UserId IN (SELECT UserId FROM Applications where JobId = @jobId)", job);
            queryFinal = from users in _context.ApplicationPhasesHelpers
                         join applications in _context.Applications.Where(a => a.AppUserId == AppUserId)
                             on users.ApplicationId equals applications.Id
                         select users;
            return await queryFinal.AsNoTracking().ToListAsync();
        }
    }
}
