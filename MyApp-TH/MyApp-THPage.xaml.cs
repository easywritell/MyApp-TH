using Xamarin.Forms;

namespace MyAppTH
{
    public partial class MyApp_THPage : ContentPage
    {
        public MyApp_THPage()
        {
            InitializeComponent();


            genderPicker.Items.Add("เพศชาย");
            genderPicker.Items.Add("เพศหญิง");

            salarySlider.ValueChanged += SalarySlider_ValueChanged;
            childentStepper.ValueChanged += ChildentStepper_ValueChanged;
        }

        void SalarySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;

        }

        void ChildentStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
        }
    }
}
