using HsrOrderApp.SharedLibraries.DTO;
using HsrOrderApp.UI.WPF.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HsrOrderApp.UI.WPF.ViewModels.Supplier
{
    public class SupplierDetailViewModel : DetailViewModelBase<SupplierDTO>
    {
        public SupplierDetailViewModel (SupplierDTO supplier, bool isNew) : base(supplier, isNew)
        {
            this.DisplayName = "LieferantenVerwaltung";
        }

        protected override void SaveData()
        {
            Service.StoreSupplier(Model);
            SaveCommandExecuted();
        }
    }
}
