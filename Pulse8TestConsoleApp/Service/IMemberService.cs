using Pulse8TestConsoleApp.Model;
using System.Collections.Generic;

namespace Pulse8TestConsoleApp.Service
{
    public interface IMemberService
    {
        List<MemberCategory> GetMemberCategories(int memberId);
    }
}
