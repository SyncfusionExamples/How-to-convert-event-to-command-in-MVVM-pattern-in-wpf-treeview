#region Copyright Syncfusion Inc. 2001 - 2011
// Copyright Syncfusion Inc. 2001 - 2011. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.ComponentModel;
using Syncfusion.Windows.Shared;
using System.Windows.Media.Imaging;

namespace TreeViewEventToCommandDemo
{
    public class Model : NotificationObject
    {
        public Model()
        {
            Models = new ObservableCollection<Model>();
        }

        private ObservableCollection<Model> models;
        public ObservableCollection<Model> Models
        {
            get
            {
                return models;
            }

            set
            {
                models = value;
                this.RaisePropertyChanged("Models");
            }
        }

        #region TreeViewItemAdv Properties

        private string state;
        /// <summary>
        /// Gets or sets a value indicating the Header of the TreeViewItemAdv.
        /// </summary>        
        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
                this.RaisePropertyChanged("State");
            }
        }
       

        #endregion
    }
}
