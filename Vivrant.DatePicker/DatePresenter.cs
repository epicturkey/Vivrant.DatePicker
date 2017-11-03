using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Vivrant.Presenter
{
    public class DatePresenter : PresenterBase
    {
        public DatePresenter()
        {

        }
        private DateTime _dt;
        public DateTime Date
        {
            get { return _dt; }
            set {
                _dt = value;
                RaisePropertyChangedEvent("Date");
            }
        }
    }
}
