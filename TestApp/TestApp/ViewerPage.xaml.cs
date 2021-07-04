using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;
using System.Reflection;

namespace TestApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewerPage : ContentPage
    {
        Stream fileStream;
        public ViewerPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            fileStream = typeof(App).GetTypeInfo().Assembly.GetManifestResourceStream("TestApp.Resources.Issues.Fauna Universal.pdf");
            //Load the PDF
            pdfViewerControl.LoadDocument(fileStream);
        }

    }
}