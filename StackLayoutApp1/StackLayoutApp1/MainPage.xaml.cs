using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayoutApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        /*
         <!--Контейнер для сложного интерфейса--><!--
    <StackLayout>
        --><!--Рамка--><!--
        <Frame BorderColor="Yellow">
            <StackLayout Orientation="Horizontal" Spacing="15">

                <BoxView Color="Red" />
                <Label Text="первый элемент"
                       VerticalOptions="Center"/>

            </StackLayout>
        </Frame>

        <Frame BorderColor="Black">
            <StackLayout Orientation="Horizontal" Spacing="15">

                <BoxView Color="Green" />
                <Label Text="Второйэлемент"
                       VerticalOptions="Center"/>

            </StackLayout>
        </Frame>

        <Frame BorderColor="Blue">
            <StackLayout Orientation="Horizontal" Spacing="15">

                <BoxView Color="DarkCyan" />
                <Label Text="Третий элемент"
                       VerticalOptions="Center"/>

            </StackLayout>
        </Frame>
    </StackLayout>-->

        делаем тоже самое что выше, но в коде C#
         */
        protected override void OnAppearing()
        {
            StackLayout stackLayout1 = new StackLayout();

            Frame frame1 = null;

            for (int i = 0; i < 15; i++)
            {
                frame1 = new Frame()
                {
                    //новый горизонтальный стек
                    Content = new StackLayout()
                    {
                        Children =
                    {
                        new BoxView(){Color = Color.FromRgb(i*5,i*10,i*15)},
                        new Label(){Text = $"{i} элемент", VerticalOptions=LayoutOptions.Center}
                    },
                        Orientation = StackOrientation.Horizontal,
                        Spacing = 15
                    },
                    BorderColor = Color.FromRgb(i*5,i*6,i*7)
                };

                stackLayout1.Children.Add(frame1);

            }

            

            Content = stackLayout1;

















            /*
            //главный стек
            StackLayout stackLayout1 = new StackLayout();

            Frame frame1 = new Frame() 
            { 
                //новый горизонтальный стек
                Content = new StackLayout()
                {
                    Children=
                    {
                        new BoxView(){Color = Color.DarkGoldenrod},
                        new Label(){Text = "Первый элемент", VerticalOptions=LayoutOptions.Center}
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15
                },
                BorderColor = Color.Red,
            };

            Frame frame2 = new Frame()
            {
                //новый горизонтальный стек
                Content = new StackLayout()
                {
                    Children =
                    {
                        new BoxView(){Color = Color.DarkBlue},
                        new Label(){Text = "Второй элемент", VerticalOptions=LayoutOptions.Center}
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15
                },
                BorderColor = Color.Red,
            };

            Frame frame3 = new Frame()
            {
                //новый горизонтальный стек
                Content = new StackLayout()
                {
                    Children =
                    {
                        new BoxView(){Color = Color.Crimson},
                        new Label(){Text = "Третий элемент", VerticalOptions=LayoutOptions.Center}
                    },
                    Orientation = StackOrientation.Horizontal,
                    Spacing = 15
                },
                BorderColor = Color.Red
            };

            stackLayout1.Children.Add(frame1);
            stackLayout1.Children.Add(frame2);
            stackLayout1.Children.Add(frame3);

            Content = stackLayout1;
            */
        }
    }
}
