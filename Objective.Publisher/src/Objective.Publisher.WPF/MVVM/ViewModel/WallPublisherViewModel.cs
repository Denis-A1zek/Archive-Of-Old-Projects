using Objective.Publisher.App;
using Objective.Publisher.Core;
using Objective.Publisher.WPF.Common.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Publisher.WPF.MVVM.ViewModel
{
    public class WallPublisherViewModel : ObservableObject
    {
        private CommunityManager _manager;

        public WallPublisherViewModel(CommunityManager manager)
        {
            _manager = manager;
            InitComponent();
        }

        private ObservableCollection<IMarketProduct> _products;
        public ObservableCollection<IMarketProduct> Products
        {
            get { return _products; }
            set 
            {
                _products = value;
                OnPropertChanged("Products");
            }
        }

        private IMarketProduct _selectedProduct;
        public IMarketProduct SelectedProduct
        {
            get { return _selectedProduct; }
            set
            {
                _selectedProduct = value;
                OnPropertChanged("SelectedProduct");
            }
        }

        private async void InitComponent()
        {
            var products = await _manager.GetProductFromMarketAsync();

            Products = new ObservableCollection<IMarketProduct>(products);
        }
    }
}
