using Pulse8TestConsoleApp.Data;
using Pulse8TestConsoleApp.Model;
using System.Collections.Generic;

namespace Pulse8TestConsoleApp.Service
{
    public class MemberService : IMemberService
    {
        private readonly IMemberRepository _memberRepository;

        public MemberService(IMemberRepository memberRepository)
        {
            _memberRepository = memberRepository;
        }

        public List<MemberCategory> GetMemberCategories(int memberId)
        {
            return _memberRepository.SelectMemberCategories(memberId);
        }
    }
}
