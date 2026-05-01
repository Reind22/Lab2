using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace WpfLab2.Views
{
    public partial class TwoWayBindingView : UserControl
    {
        public TwoWayBindingView()
        {
            InitializeComponent();
        }

        private void ApplyRole_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression be = RoleBox.GetBindingExpression(TextBox.TextProperty);
            if (be != null)
            {
                be.UpdateSource();
            }
        }
    }
}
