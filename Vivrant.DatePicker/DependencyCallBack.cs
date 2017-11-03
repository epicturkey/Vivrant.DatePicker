using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Vivrant.Controls
{
    public static class DependancyCallback
    {
        public static DependencyProperty RegisterDependencyPropertyWithCallback<TObject, TProperty>(string propertyName, TProperty defaultValue, Func<TObject, Action<TProperty, TProperty>> getOnChanged)
            where TObject : DependencyObject
        {
            return DependencyProperty.Register(
                propertyName,
                typeof(TProperty),
                typeof(TObject),
                new PropertyMetadata(
                    defaultValue,
                    new PropertyChangedCallback(
                        (d, e) =>
                        getOnChanged((TObject)d)
                        ((TProperty)e.OldValue,
                        (TProperty)e.NewValue)
                ))
            );
        }
    }
}
