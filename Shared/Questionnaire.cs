﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XebecPortal.Shared.Security;

namespace XebecPortal.Shared
{
    public class Questionnaire
    {
        public int Id { get; set; }

        public decimal ExpectedSalary { get; set; }

        public DateTime StartDate { get; set; }

        public int NoticePeriodId { get; set; }

        public NoticePeriod NoticePeriod { get; set; }

        public int LocationId { get; set; }

        public Location Location { get; set; }

        public int Experience { get; set; }

        public int PermissionId { get; set; }

        public Permission Permission { get; set; }

        public int CitizenshipId { get; set; }

        public Citizenship Citizenship { get; set; }

        public int VisaId { get; set; }

        public Visa Visa { get; set; }

        public int WorkPermitId { get; set; }

        public WorkPermit WorkPermit { get; set; }

        public string University { get; set; }

        //public DateTime EndDate { get; set; }

        public int JobPlatformId { get; set; }

        public JobPlatform JobPlatform { get; set; }

        public int AppUserId { get; set; }

        public AppUser AppUser { get; set; }
    }
}
