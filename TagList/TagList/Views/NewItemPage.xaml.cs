﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TagList.Models;
using TagList.ViewModels;

namespace TagList.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class NewItemPage : ContentPage
    {
        public NewItemViewModel ViewModel { get; }

        public NewItemPage()
        {
            InitializeComponent();

            BindingContext = ViewModel = new NewItemViewModel();
        }
    }
}