using Pulse8TestConsoleApp.Model;
using System.Collections.Generic;

namespace Pulse8TestConsoleApp.Data
{
    public class MemberRepository : IMemberRepository
    {
        private readonly Pulse8TestDBEntities _dbContext;

        public MemberRepository(Pulse8TestDBEntities dbContext)
        {
            _dbContext = dbContext;
        }

        public List<MemberCategory> SelectMemberCategories(int memberId)
        {
            var result = _dbContext.SelectMemberCategories(memberId);

            return AutoMapper.Mapper.Map<List<MemberCategory>>(result);
        }
    }
}
