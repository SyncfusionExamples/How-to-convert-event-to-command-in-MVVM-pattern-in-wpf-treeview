#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using Syncfusion.UI.Xaml.TreeView;
using Syncfusion.Windows.Shared;

namespace TreeViewEventToCommandDemo
{
    public class ViewModel : NotificationObject
    {
        public ObservableCollection<Model> Items { get; set; }

        private ICommand selectionChangedCommand;

        public ICommand SelectionChangedCommand
        {
            get
            {
                return selectionChangedCommand;
            }
            set
            {
                selectionChangedCommand = value;
            }
        }
       
        public ViewModel()
        {
            Items = new ObservableCollection<Model>();

            SelectionChangedCommand = new BaseCommand(OnSelectionChanged);

            var country1 = new Model { State = "Australia" };
            var country2 = new Model { State = "Brazil" };
            var country3 = new Model { State = "China" };
            var country4 = new Model { State = "France" };            

            var aus_state1 = new Model { State = "New South Wales" };
            var aus_state2 = new Model { State = "Victoria" };
            var aus_state3 = new Model { State = "South Autralia" };
            var aus_state4 = new Model { State = "Western Australia" };

            var brazil_state1 = new Model { State = "Parana" };
            var brazil_state2 = new Model { State = "Ceara" };
            var brazil_state3 = new Model { State = "Acre" };

            var china_state1 = new Model { State = "Guangzhou" };
            var china_state2 = new Model { State = "Shanghai" };
            var china_state3 = new Model { State = "Beijing" };
            var china_state4 = new Model { State = "Shantou" };

            var france_state1 = new Model { State = "Pays de la Loire" };
            var france_state2 = new Model { State = "Aquitaine" };
            var france_state3 = new Model { State = "Brittany" };
            var france_state4 = new Model { State = "Lorraine" };
          
            country1.Models.Add(aus_state1);
            country1.Models.Add(aus_state2);
            country1.Models.Add(aus_state3);
            country1.Models.Add(aus_state4);

            country2.Models.Add(brazil_state1);
            country2.Models.Add(brazil_state2);
            country2.Models.Add(brazil_state3);

            country3.Models.Add(china_state1);
            country3.Models.Add(china_state2);
            country3.Models.Add(china_state3);
            country3.Models.Add(china_state4);

            country4.Models.Add(france_state1);
            country4.Models.Add(france_state2);
            country4.Models.Add(france_state3);
            country4.Models.Add(france_state4);

            Items.Add(country1);
            Items.Add(country2);
            Items.Add(country3);
            Items.Add(country4);
        }

        private void OnSelectionChanged(object obj)
        {
            var args = obj as ItemSelectionChangedEventArgs;
            if (args.AddedItems.Count > 0)
                MessageBox.Show("Selected State: " + (args.AddedItems[0] as Model).State.ToString());
        }

        
    }
}
