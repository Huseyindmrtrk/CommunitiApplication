using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace CommunitiApp.Enums
{
    public enum UserType
    {
        SuperAdmin,
        Admin,
        Members,
        Visitors
    }
    public enum UserState
    {
        WaitingActivation,
        Active,
        Passive
    }
}