#region

using System.Runtime.Serialization;
using HsrOrderApp.SharedLibraries.DTO.Requests_Responses.Base;
using Microsoft.Practices.EnterpriseLibrary.Validation.Validators;

#endregion

namespace HsrOrderApp.SharedLibraries.DTO.Requests_Responses
{
    [DataContract]
    public class StoreSupplierRequest : RequestType
    {
        [DataMember]
        [ObjectValidator]
        public SupplierDTO Supplier { get; set; }
    }
}