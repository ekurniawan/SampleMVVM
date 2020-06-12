using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SamplePrism.ViewModels
{
    //
    public class SampleCalculatorViewModel : ViewModelBase
    {
        public SampleCalculatorViewModel(INavigationService navigationServices):base(navigationServices)
        {
            Title = "Contoh Calculator";
            Bilangan1 = 10;
            Bilangan2 = 20;
        }

        private double _bilangan1;
        public double Bilangan1
        {
            get { return _bilangan1; }
            set { SetProperty(ref _bilangan1, value); }
        }

        private double _bilangan2;
        public double Bilangan2
        {
            get { return _bilangan2; }
            set { SetProperty(ref _bilangan2, value); }
        }

        private double _hasil;
        public double Hasil
        {
            get { return _hasil; }
            set { SetProperty(ref _hasil, value); }
        }

        private DelegateCommand _calculateCommand;
        public DelegateCommand CalculateCommand => _calculateCommand ??
            (_calculateCommand = new DelegateCommand(TambahBilangan));

        private DelegateCommand _navigateToMenu;
        public DelegateCommand NavigateToMenu => _navigateToMenu ??
            (_navigateToMenu = new DelegateCommand(NavigasiKeMenu));

        private async void NavigasiKeMenu()
        {
            await NavigationService.NavigateAsync("MainPage");
        }

        private void TambahBilangan()
        {
            Hasil = Bilangan1 + Bilangan2;
        }
    }
}
