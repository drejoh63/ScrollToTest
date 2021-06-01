using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using ScrollToTest.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ScrollToTest.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        public ObservableCollection<State> States { get; set; }

        public MainPageViewModel()
        {
            States = new ObservableCollection<State>();
            States = _states;
        }

        private readonly ObservableCollection<State> _states = new ObservableCollection<State>()
        {
            new State() { StateId = 1, StateName = "Alabama", StateValue = "AL"},
            new State() { StateId = 2, StateName = "Alaska", StateValue = "AK"},
            new State() { StateId = 3, StateName = "Arizona", StateValue = "AZ"},
            new State() { StateId = 4, StateName = "Arkansas", StateValue = "AR"},
            new State() { StateId = 5, StateName = "California", StateValue = "CA"},
            new State() { StateId = 6, StateName = "Colorado", StateValue = "CO"},
            new State() { StateId = 7, StateName = "Connecticut", StateValue = "CT"},
            new State() { StateId = 8, StateName = "Delaware", StateValue = "DE"},
            new State() { StateId = 9, StateName = "Florida", StateValue = "FL"},
            new State() { StateId = 10, StateName = "Georgia", StateValue = "GA"},
            new State() { StateId = 11, StateName = "Hawaii", StateValue = "HI"},
            new State() { StateId = 12, StateName = "Idaho", StateValue = "ID"},
            new State() { StateId = 13, StateName = "Illinois", StateValue = "IL"},
            new State() { StateId = 14, StateName = "Indiana", StateValue = "IN"},
            new State() { StateId = 15, StateName = "Iowa", StateValue = "IA"},
            new State() { StateId = 16, StateName = "Kansas", StateValue = "KS"},
            new State() { StateId = 17, StateName = "Kentucky", StateValue = "KY"},
            new State() { StateId = 18, StateName = "Louisiana", StateValue = "LA"},
            new State() { StateId = 19, StateName = "Maine", StateValue = "ME"},
            new State() { StateId = 20, StateName = "Maryland", StateValue = "MD"},
            new State() { StateId = 21, StateName = "Massachusetts", StateValue = "MA"},
            new State() { StateId = 22, StateName = "Michigan", StateValue = "MI"},
            new State() { StateId = 23, StateName = "Minnesota", StateValue = "MN"},
            new State() { StateId = 24, StateName = "Mississippi", StateValue = "MS"},
            new State() { StateId = 25, StateName = "Missouri", StateValue = "MO"},
            new State() { StateId = 26, StateName = "Montana", StateValue = "MT"},
            new State() { StateId = 27, StateName = "Nebraska", StateValue = "NE"},
            new State() { StateId = 28, StateName = "Nevada", StateValue = "NV"},
            new State() { StateId = 29, StateName = "New Hampshire", StateValue = "NH"},
            new State() { StateId = 30, StateName = "New Jersey", StateValue = "NJ"},
            new State() { StateId = 31, StateName = "New Mexico", StateValue = "NM"},
            new State() { StateId = 32, StateName = "New York", StateValue = "NY"},
            new State() { StateId = 33, StateName = "North Carolina", StateValue = "NC"},
            new State() { StateId = 34, StateName = "North Dakota", StateValue = "ND"},
            new State() { StateId = 35, StateName = "Ohio", StateValue = "OH"},
            new State() { StateId = 36, StateName = "Oklahoma", StateValue = "OK"},
            new State() { StateId = 37, StateName = "Oregon", StateValue = "OR"},
            new State() { StateId = 38, StateName = "Pennsylvania", StateValue = "PA"},
            new State() { StateId = 39, StateName = "Rhode Island", StateValue = "RI"},
            new State() { StateId = 40, StateName = "South Carolina", StateValue = "SC"},
            new State() { StateId = 41, StateName = "South Dakota", StateValue = "SD"},
            new State() { StateId = 42, StateName = "Tennessee", StateValue = "TN"},
            new State() { StateId = 43, StateName = "Texas", StateValue = "TX"},
            new State() { StateId = 44, StateName = "Utah", StateValue = "UT"},
            new State() { StateId = 45, StateName = "Vermont", StateValue = "VT"},
            new State() { StateId = 46, StateName = "Virginia", StateValue = "VA"},
            new State() { StateId = 47, StateName = "Washington", StateValue = "WA"},
            new State() { StateId = 48, StateName = "West Virginia", StateValue = "WV"},
            new State() { StateId = 49, StateName = "Wisconsin", StateValue = "WI"},
            new State() { StateId = 50, StateName = "Wyoming", StateValue = "WY"},
            new State() { StateId = 51, StateName = "Canada", StateValue = "CAN"},
            new State() { StateId = 52, StateName = "Mexico", StateValue = "MEX"}
        };
    }
}
