using Autofac.Extras.Moq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pulse8TestConsoleApp.Data;
using Pulse8TestConsoleApp.Model;
using Pulse8TestConsoleApp.Service;
using System.Collections.Generic;

namespace Pulse8TestConsoleApp.Tests
{
    [TestClass]
    public class MemberServiceTests
    {
        [TestMethod]
        public void MemberService_ShouldReturnCorrectCategories_ForGivenMemberID()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //arrange
                var memberId = 1;
                var memberCategories = new List<MemberCategory>()
                {
                    new MemberCategory() { MemberId = 1, CategoryId = 1 },
                    new MemberCategory() { MemberId = 1, CategoryId = 2 }                    
                };

                mock.Mock<IMemberRepository>().Setup(m => m.SelectMemberCategories(memberId)).Returns(memberCategories);

                //act
                var memberService = mock.Create<MemberService>();
                var result = memberService.GetMemberCategories(memberId);

                //assert
                result.Should().NotBeNull();
                result.Count.Should().Be(2);
                result[0].CategoryId.Should().Be(1);
                result[1].CategoryId.Should().Be(2);
            }
        }
    }
}
