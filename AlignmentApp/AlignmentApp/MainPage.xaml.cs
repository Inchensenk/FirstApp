using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AlignmentApp
{
    /*
     <StackLayout Margin="15">

        <Label Text="Слева"
               BackgroundColor="Gray"
               HorizontalOptions="Start"/> --><!--HorizontalOptions="Start": Элемент притянут к левому краю экрана--><!--

        <Label Text="По центру"
               BackgroundColor="Gray"
               HorizontalOptions="Center"/> --><!--HorizontalOptions="Center": Центрует элемент по середине--><!--

        <Label Text="Справа"
               BackgroundColor="Gray"
               HorizontalOptions="End"/>   --><!--HorizontalOptions="End": Элемент притянут к правому краю экрана--><!--

        <Label Text="Растянуть по Ox"
               BackgroundColor="Gray"
               HorizontalOptions="Fill"/>  --><!--HorizontalOptions="Fill": Элемент растянут на всю ширину родительского контейнера--><!--

    </StackLayout>

    Реализация тоже самого, но в C#. в Методе OnAppearing()
     */
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// обрабатываем события создания событий
        /// </summary>
        protected override void OnAppearing()
        {
            /*//горизонтальный стек
            StackLayout stackLayout2 = new StackLayout()
            {
                Margin = new Thickness(15),
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new Label {Text= "Слева", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Start},
                    new Label {Text= "По центру", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Center},
                    new Label {Text= "Справа", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.End},
                    new Label {Text= "На всю ширину", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.Fill}
                }
            };
            Content = stackLayout2;*/


            /*
            //Вертикальный стек
            StackLayout stackLayout1 = new StackLayout()
            {
                Margin = new Thickness(15),
                Children =
                {
                    new Label {Text= "Слева", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.Start},
                    new Label {Text= "По центру", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.Center},
                    new Label {Text= "Справа", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.End},
                    new Label {Text= "На всю ширину", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.Fill}
                }
            };
            Content = stackLayout1;*/
        }
    }
}
