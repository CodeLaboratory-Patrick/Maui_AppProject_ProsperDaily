using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class DashboardPage : ContentPage
{
    public DashboardPage()
    {
        InitializeComponent();
        BindingContext = new DashboardViewModel();
    }

    private async void AddTransaction_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PushAsync(new TransactionPage());
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        var vm = (DashboardViewModel)BindingContext;
        vm.FillData();
    }
}