using CommunityToolkit.Mvvm.ComponentModel;
using PetLink.Models.Titles;
using System;
using System.Collections.Generic;
using System.Text;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace PetLink.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleRegister.Title;
    }
}
