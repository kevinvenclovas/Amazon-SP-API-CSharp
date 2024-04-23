using FikaAmazonAPI.AmazonSpApiSDK.Models.FulfillmentInbound;
using FikaAmazonAPI.Search;

namespace FikaAmazonAPI.Parameter.FulFillmentInbound
{
    public class ParameterGetListInboundPlans : ParameterBased
    {
        public int? PageSize { get; set; }
        public string PaginationToken { get; set; }
        public Status? Status { get; set; }
        public SortBy? SortBy { get; set; }
        public SortOrder? sortOrder { get; set; }
    }
}
