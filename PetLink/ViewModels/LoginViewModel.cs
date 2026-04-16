using CommunityToolkit.Mvvm.ComponentModel;
using PetLink.Models.Titles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public class LoginViewModel : ObservableObject
    {
        public string Title => TitleLogin.Title;
        public string UsernameText => TitleLogin.UsernameText;
        public string PasswordText => TitleLogin.PasswordText;
        public string Submit => TitleLogin.Submit;
    }

}
