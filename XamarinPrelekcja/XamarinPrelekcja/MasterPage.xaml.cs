using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinPrelekcja
{
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage()
        {
            InitializeComponent();
            object context = new
            {
               Title = Device.OS.ToString()
            };
            this.BindingContext = context;
        }
    }
}
