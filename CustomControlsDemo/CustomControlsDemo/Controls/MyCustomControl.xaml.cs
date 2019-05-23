using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CustomControlsDemo.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomControl : ContentView
    {
        public MyCustomControl()
        {
            InitializeComponent();
        }

        public string PersonName
        {
            get => Person.Text;
            set => Person.Text = value;
        }

        public static readonly BindableProperty PersonNameProperty =
            BindableProperty.Create(
                nameof(PersonName),
                typeof(string),
                typeof(MyCustomControl),
                "No one",
                propertyChanged: PersonNameChanged);

        private static void PersonNameChanged(object bindable, object oldValue, object newValue)
        {
            var b = (MyCustomControl)bindable;
            b.PersonName = (string)newValue;
        }
    }
}