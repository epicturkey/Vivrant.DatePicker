using CSHTML5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Vivrant.Controls
{
    public partial class DatePicker : UserControl
    {
        #region Constructor
        public DatePicker()
        {
            this.Loaded += DatePicker_Loaded;
            Interop.LoadCssFile("ms-appx:///Vivrant.DatePicker/css/datepicker.css");
            CSharpXamlForHtml5.DomManagement.SetHtmlRepresentation(this, "<input type='date'>");
            this.InitializeComponent();
        }
        #endregion
        #region PropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(String propName)
        {
            var args = new PropertyChangedEventArgs(propName);
            this.PropertyChanged?.Invoke(this, args);
        }
        private void OnDateChanged<T>(T oldFoo, T newFoo)
        {
            //superflous - not needed, but good for debugging
            //debug
            //if(!newFoo.Equals(oldFoo))
            //    MessageBox.Show(String.Format("DateChanged {0}", newFoo));
        }
        #endregion
        #region Loaded Event
        private void DatePicker_Loaded(object sender, RoutedEventArgs e)
        {// Get the reference to the "input" element:
            var inputElement = CSHTML5.Interop.GetDiv(this);

            Action<string> OnChanged = (content) =>
            {
                try
                {
                    DateTime dt = DateTime.Parse(content);
                    this.DateValue = dt;
                }
                catch(Exception ex)
                {
                    //invalid dt value
                    this.DateValue = null;
                }
            };

            // Listen to the "change" property of the "input" element, and call the callback:
            CSHTML5.Interop.ExecuteJavaScript(@"
                $0.addEventListener(""input"", function(e){
                    if(!e){
                      e = window.event;
                    }
                    $1(this.value);
                });", inputElement, OnChanged);
        }
        #endregion
        #region Dependancy Properties
        public static readonly DependencyProperty DateValueProperty =
            DependancyCallback.RegisterDependencyPropertyWithCallback<DatePicker, DateTime?>(
                "DateValue",
                null,
                x => x.OnDateChanged);
        public DateTime? DateValue
        {
            get { return (DateTime?)this.GetValue(DatePicker.DateValueProperty); }
            set
            {
                this.SetValue(DatePicker.DateValueProperty, value);
                this.RaisePropertyChanged("DateValue");
            }
        }
        #endregion
    }
}
