using CommunityToolkit.Mvvm.ComponentModel;
using PetLink.Models.Titles;
using System;
using System.Collections.Generic;
using System.Text;

namespace PetLink.ViewModels
{
    public partial class PetProfileViewModel : ObservableObject
    {
        public string Name => TitlePetProfile.Name;

    }
}
