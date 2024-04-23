using FikaAmazonAPI.Search;

namespace FikaAmazonAPI.Parameter.FulFillmentInbound
{
    public class ParameterListInboundPlan : ParameterBased
    {
        public string InboundPlanId { get; set; }
        public int? PageSize { get; set; }
        public string PaginationToken { get; set; }
    }
}
