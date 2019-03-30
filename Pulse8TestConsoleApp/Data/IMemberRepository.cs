using Pulse8TestConsoleApp.Model;
using System.Collections.Generic;

namespace Pulse8TestConsoleApp.Data
{
    public interface IMemberRepository
    {
        List<MemberCategory> SelectMemberCategories(int memberId);
    }
}
