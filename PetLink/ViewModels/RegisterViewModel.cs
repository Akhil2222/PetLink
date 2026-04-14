using Android.Database;
using PetLink.Models.Titles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public partial class RegisterViewModel : ObservableObject
    {
        [ObservableProperty]
        private string title = TitleRegister.Title;
    }
}
