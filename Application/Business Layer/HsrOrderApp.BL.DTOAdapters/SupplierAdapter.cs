using HsrOrderApp.BL.BusinessComponents;
using HsrOrderApp.BL.DomainModel;
using HsrOrderApp.BL.DTOAdapters.Helper;
using HsrOrderApp.SharedLibraries.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HsrOrderApp.BL.DTOAdapters
{
    class SupplierAdapter
    {
        #region SupplierToDTO

        public static IList<SupplierListDTO> CustomersToDtos(IQueryable<Supplier> suppliers)
        {
            IQueryable<SupplierListDTO> supplierDtos = from s in suppliers
                                                       select new SupplierListDTO()
                                                       {
                                                           AccountNumber = s.AccountNumber,
                                                           CreditRating = s.CreditRating,
                                                           PreferedSupplier = s.PreferedSupplier,
                                                           ActiveFlag = s.ActiveFlag,
                                                           Name = s.Name
                                                       };
            return supplierDtos.ToList();
        }

        public static SupplierDTO SupplierToDto(Supplier s)
        {
            SupplierDTO dto = new SupplierDTO()
            {
                AccountNumber = s.AccountNumber,
                ActiveFlag = s.ActiveFlag,
                CreditRating = s.CreditRating,
                Version = s.Version,
                PreferredSupplier = s.PreferedSupplier,
                Name = s.Name
            };

            return dto;
        }

       #endregion

        #region DTOToCustomer

        public static Supplier DtoToSupplier(SupplierDTO dto)
        {
            Supplier supplier = new Supplier()
            {
                AccountNumber = dto.Id,
                Name = dto.Name,
                ActiveFlag = dto.ActiveFlag,
                Version = dto.Version,
                CreditRating = dto.CreditRating,
                PreferedSupplier = dto.PreferredSupplier,
            };
            ValidationHelper.Validate(supplier);
            return supplier;
        }

        //public static IEnumerable<ChangeItem> GetChangeItems(SupplierDTO dto, Supplier supplier)
        //{
        //    IEnumerable<ChangeItem> changeItems = from c in dto.Changes
        //                                          select
        //                                          new ChangeItem(c.ChangeType, AddressAdapter.DtoToAddress((AddressDTO)c.Object));
        //    return changeItems;
        //}

        #endregion
    }
}
