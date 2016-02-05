#region

using System.Runtime.Serialization;
using HsrOrderApp.SharedLibraries.DTO.Requests_Responses.Base;
using HsrOrderApp.SharedLibraries.SharedEnums;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

#endregion

namespace HsrOrderApp.SharedLibraries.DTO.Requests_Responses
{
    [DataContract]
    public class GetSuppliersRequest : RequestType
    {
        [DataMember]
        public int? Preferred { get; set; }

        [DataMember]
        public int? Active { get; set; }

        [DataMember]
        public CreditRating CreditRating { get; set; }
    }
}