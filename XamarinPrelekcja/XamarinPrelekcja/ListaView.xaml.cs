using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace XamarinPrelekcja
{
    public class ListaItem
    {
        public int ID { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
    }

    public partial class ListaView : ContentView
    {
        private IEnumerable<ListaItem> lista;
        public ListaView()
        {
            InitializeComponent();
            lista = new List<ListaItem>()
            {
                new ListaItem()
                {
                    ID=0,
                    Imie="Damian",
                    Nazwisko = "Kowalski"
                },
                 new ListaItem()
                {
                    ID=1,
                    Imie="Adrian",
                    Nazwisko = "Kowalski"
                },
                  new ListaItem()
                {
                    ID=2,
                    Imie="Michal",
                    Nazwisko = "Kowalski"
                },
                   new ListaItem()
                {
                    ID=3,
                    Imie="Tomek",
                    Nazwisko = "Kowalski"
                }
            };
            Lista.ItemsSource = lista;
        }

       
    }
}
