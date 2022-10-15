using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ButtonApp
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            
            Button btn = null;
            for (int i = 0; i < 10; i++)
            {
                btn = new Button();

                btn.Text = $"Кнопка {i}";
                btn.BackgroundColor = Color.FromRgb(i * 9, i * 27, i * 19);
                

                btn.Clicked += OnButton2Clicked;

                
                stackLayout1.Children.Add(btn);
            }
        }

        /// <summary>
        /// будем каждый раз выводить уведомление о том, какая кнопка нажата
        /// </summary>
        /// <param name="sender">обьект отправитель, который содержит в себе ссылку на объект, который вызвал событие и соответсвенно после чего был вызван обработчик событий мы и можем получить все данные, более того, мы можем получить сам объект, который послужил началом вызова события</param>
        /// <param name="e"></param>
        private async void OnButton2Clicked(object sender, EventArgs e)
        {
            //(sender as Button).Text:
            //c помощью оператора as будем приводить отправителя типа object к типу Button
            //и будем на получившемся объекте получать свойство Text
            await DisplayAlert("", $"{(sender as Button).Text}", "Окай");
        }


        /*
        //Подписка на кнопку с помощью бэкэнда
        protected override void OnAppearing()
        {
            //подписываем метод на событие
            button1.Clicked += OnButton1Clicked; 
        }

        /// <summary>
        /// обработка события
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void OnButton1Clicked(object sender, EventArgs e)
        {
            //вызываем метод DisplayAlert() в который передаем 3 параметра:
            //заголовок уведомления, сообщение, надпись на кнопке которая будет закрывать уведомление
            await DisplayAlert("Че смотришь?","Хватит смотреть!","Перестать смотреть");
        }

        /// <summary>
        /// при нажатии на кнопку, приложение закроется
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnButtonClicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        */
    }
}
