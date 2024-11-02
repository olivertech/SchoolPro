namespace SchoolPro.Shared.Responses.Base
{
    public class ResponsePagedBase
    {
        public int PageNumber { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages => (int)Math.Ceiling(TotalCount / (double)PageSize);
        public int PageSize { get; set; } = SharedConfigurations.PageSize; //Fixo e Parametrizado
        public Guid? ClientSchoolKey { get; set; }
    }
}
