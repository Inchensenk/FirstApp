using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace StackLayoutApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       /*Аналог кода из XML на C#
         <StackLayout Orientation = "Vertical" >
            < Label Text="Основные цвета"/>
            <BoxView Color = "Red" />
            < BoxView Color="Yellow"/>
            <BoxView Color = "Blue" />

            < Label Text="Смесовые цвета"/>
            <BoxView Color = "Green" />
            < BoxView Color="Orange"/>
            <BoxView Color = "Purple" />
        </ StackLayout >*/
        //событие, которое срабатывает при появлении страницы
        protected override void OnAppearing()
        {

            Content = new StackLayout()
            {
                Orientation = StackOrientation.Horizontal,
                Children =
                {
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Green },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple }
                }

            };


            /*Вертикальный стек
            StackLayout stackLayout = new StackLayout()
            {
                Children =
                {
                    //Margin = new Thickness(0,0,0,10) это отступы: слева 0, сверху 0, справа 0, снизу 10
                    new Label { Text = "Основные цвета", Margin = new Thickness(0,0,0,10) },
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },

                    //Margin = new Thickness(0,30,0,10) это отступы: слева 0, сверху 30, справа 0, снизу 10
                    new Label { Text = "Смесовые цвета", Margin = new Thickness(0,30,0,10)},
                    new BoxView { Color = Color.Green },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple }
                },
                Spacing = 0
            };

            Content = stackLayout;
            */






            /*Label label1 = new Label() { Text = "Основные цвета" };

            BoxView boxView1 = new BoxView() { Color = Color.Red };

            stackLayout.Children.Add(label1);*/
        }
    }
}

/*
  StackLayout это самый простой и самый удобный для использования контейнер для элементов.
  Потому, что он представляет элементы в виде одномерного стека, то есть элементы распологаются один под другим дибо по вертикали.
  По типу стопки тарелок, одна лежит под другой.
  Или может быть горизонтальный стек, где элементы расположены по горизонтали. 
  При этом мы не задаем элементам никаких связей друг с другом и отностельно друг с другом.
  Единственное что нужно сделать это создать контрол и добавить его в коллекцию дочерних элементов StackLayout.

  У StackLayout есть 3 основных свойства: 
  Orientation - направление стека, либо Vertical(по умолчанию), либо Horizontal
  Spacing - свойство типа double(по умолчание 6 единиц(не пикселей а именно единиц, единица независимая от экрана устройства)), указывает расстояние между каждым дочерним элементом друг от друга, то есть интервал после каждого элемента
  Children - коллекция в которую мы добавляем контроллы
   */