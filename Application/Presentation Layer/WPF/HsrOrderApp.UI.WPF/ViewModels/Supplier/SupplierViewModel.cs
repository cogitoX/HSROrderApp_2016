using HsrOrderApp.SharedLibraries.DTO;
using HsrOrderApp.UI.PresentationLogic;
using HsrOrderApp.UI.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HsrOrderApp.UI.WPF.ViewModels.Supplier
{
    public class SupplierViewModel : ListViewModelBase<SupplierListDTO>
    {
        protected override void Delete()
        {
            Service.DeleteSupplier(SelectedItem.AccountNumber);
            Load();
        }

        protected override void Edit()
        {
            SupplierDTO selectedDto = Service.GetSupplierByAccountNumber(SelectedItem.AccountNumber);
            SupplierDetailViewModel detailModelView = new SupplierDetailViewModel(selectedDto, false);
            if (NavigationService.NavigateTo("Detail", detailModelView) == NavigationResult.Ok)
            {
                Load();
                SelectedItem = Items.SingleOrDefault(dto => dto.Id == selectedDto.Id);
            }
        }

        protected override void LoadData()
        {
            this.DisplayName = "LieferantenVerwaltung";
            IList<SupplierListDTO> products = Service.GetAllSuppliers();
            foreach (SupplierListDTO product in products)
                Items.Add(product);
        }

        protected override void New()
        {
            SupplierDTO newSupplier = new SupplierDTO();
            SupplierDetailViewModel detailModelView = new SupplierDetailViewModel(newSupplier, true);
            if (NavigationService.NavigateTo("Detail", detailModelView) == NavigationResult.Ok)
            {
                Load();
                SelectedItem = Items.SingleOrDefault(dto => dto.Id == newSupplier.Id);
            }
        }
    }
}
