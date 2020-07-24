using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using WSTowerApp.Models;
using Xamarin.Forms;

namespace WSTowerApp
{
    public class ViewModel
    {
        public ObservableCollection<string> Items{ get; set; }

        public ICommand LoadCommand { get; set; }

        public ViewModel()
        {
            this.Items = new ObservableCollection<string>();
            this.LoadCommand = new Command(() => this.Load());
            this.Load();
        }
        private int index = 0;
        public void Load()
        {
            for(int i = 0; i < 10; i++)
            {
                this.Items.Add(string.Format("Item {0}", index++));
            }
        }
    }
}
