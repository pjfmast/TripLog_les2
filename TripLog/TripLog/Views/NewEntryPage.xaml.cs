using TripLog.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TripLog.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NewEntryPage : ContentPage
    {
        //NewEntryViewModel ViewModel => BindingContext as NewEntryViewModel;

        public NewEntryPage()
        {
            InitializeComponent();

            //BindingContextChanged += Page_BindingContextChanged;

            // The BindingContext can be set in xaml or in code here:
            //BindingContext = new NewEntryViewModel();
        }

        //// Observe ErrorsChanged event with
        //void Page_BindingContextChanged(object sender, EventArgs e)
        //{
        //    ViewModel.ErrorsChanged += ViewModel_ErrorsChanged;
        //}

        //void ViewModel_ErrorsChanged(object sender, DataErrorsChangedEventArgs e)
        //{
        //    var propHasErrors = (ViewModel.GetErrors(e.PropertyName) as List<string>)?.Any() == true;

        //    switch (e.PropertyName)
        //    {
        //        case nameof(ViewModel.Title):
        //            title.LabelColor = propHasErrors
        //                ? Color.Red : Color.Black;
        //            break;
        //        case nameof(ViewModel.Rating):
        //            rating.LabelColor = propHasErrors
        //                ? Color.Red : Color.Black;
        //            break;
        //        default:
        //            break;
        //    }
        //}
    }
}