using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SearchBarDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        private readonly List<string> _countries = new List<string>
        {
            "Andora", "Albania", "Austria", "Australia", "Belgium", "Belorussia", 
            "Bosnia", "Canada", "Croatia", "Costa Rica", "Danemark", "England", "Eritrea", "Estonia"
        };

        public MainPage()
        {
            InitializeComponent();
            SearchList.ItemsSource = _countries;
        }

        //private void OnSearchButtonPressed(object sender, EventArgs e)
        //{
        //    string keyword = SearchBar.Text;

        //    IEnumerable<string> searchResult = _countries.Where(country => country.Contains(keyword));

        //    SearchList.ItemsSource = searchResult;
        //}

        private void OnTextChanged(object sender, TextChangedEventArgs e)
        {
            string keyword = SearchBar.Text;

            if (keyword != null)
            {
                IEnumerable<string> searchResult = _countries.Where(country => country.Contains(keyword));

                SearchList.ItemsSource = searchResult;
            }
            else
            {
                SearchList.ItemsSource = _countries;
            }
        }
    }
}
