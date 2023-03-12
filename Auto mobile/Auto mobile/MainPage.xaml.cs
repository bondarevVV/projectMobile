using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Auto_mobile
{
    public partial class MainPage : ContentPage
    {
        Button button;
        public MainPage()
        {
            InitializeComponent();
            
        }


        private async void ButtonClick(object sender, EventArgs e)
        {
            /* button.Text = "Вход";
             button.TextColor = Color.LightGreen; */

            if (string.IsNullOrEmpty(nameField.Text))
                errorText.Text = "Укажите Имя";

            else if (string.IsNullOrEmpty(loginField.Text))
                errorText.Text = "Укажите логин";

            else if (string.IsNullOrEmpty(passField.Text))
                errorText.Text = "Укажите пароль";

            else if (!checkField.IsChecked)
                errorText.Text = "Подтвердите введенные данные";

            else 
            {
                errorText.Text = "";

               // await DisplayAlert("Успешно", "Добро пожаловать в магазин", "Далее");

                await Navigation.PushAsync(new _2_str());
            }
        }
    }
}
