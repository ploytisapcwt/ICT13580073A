using Xamarin.Forms;

namespace ICT13580073A
{
    public partial class ICT13580073APage : ContentPage
    {
        public ICT13580073APage()
        {
            InitializeComponent();

            okButton.Clicked+= OkButton_Clicked;
            genderPicker.Items.Add("เพศชาย");
            genderPicker.Items.Add("เพศหญิง");
            mySlider.ValueChanged += MySlider_ValueChanged;
            myStepper.ValueChanged += MyStepper_ValueChanged;
        }

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
