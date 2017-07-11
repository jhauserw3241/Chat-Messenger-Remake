using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatMessenger
{
    public class ClientPresenter
    {
        public ClientPresenter(
            ClientViewModel viewModel,
            ClientView view
            )
        {
            _view = view;
            _viewModel = viewModel;
        }

        public void Load()
        {
            _view.ShowDialog();
        }

        private ClientViewModel _viewModel;
        private ClientView _view;
    }
}
