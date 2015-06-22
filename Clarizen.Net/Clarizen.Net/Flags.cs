using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bradaz.Clarizen.API
{
    [Flags]
    public enum licenceType
    {
        Full = 0,
        Limited = 1,
        Email = 2,
        None = 3,
        TeamMember = 4,
        Social = 5
    }

    [Flags]
    public enum entityType
    {
        WorkItem = 0,
        Task = 1,
        Project = 2,
        Milestone = 3,
        Case = 4,
        Issue = 5,
        Request = 6,
        Bug = 7,
        Organisation = 8

    }
}
