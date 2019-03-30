namespace Pulse8TestConsoleApp.Model
{
    public class MemberCategory
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? MostSevereDiagnosisId { get; set; }
        public string MostSevereDiagnosisDescription { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryDescription { get; set; }
        public int? CategoryScore { get; set; }
        public bool IsMostSevereCategory { get; set; }
    }
}
