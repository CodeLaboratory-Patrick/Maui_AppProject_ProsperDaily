using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls;
using ProsperDaily.MVVM.ViewModels;

namespace ProsperDaily.MVVM.Views;

public partial class TransactionPage : ContentPage
{
    public TransactionPage()
    {
        InitializeComponent();
        BindingContext = new TransactionsViewModel();
    }

    private async void Save_OnClicked(object? sender, EventArgs e)
    {
        var currentVM = (TransactionsViewModel)BindingContext;
        var message = currentVM.SaveTransaction();
        await DisplayAlert("Info", message, "OK");
        await Navigation.PopToRootAsync();
    }

    private async void Cancel_OnClicked(object? sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }

    
}