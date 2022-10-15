using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FirstApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Пользовательский интерфейс создается в методе OnAppearing() который срабатывает при появлении страницы
        /// именно в методе OnAppearing() мы будем создавать: пользовательский интерфейс, обработчики для кнопок,  обрабатывать нажатие кнопок
        /// 
        /// Так как это метод базоваого класса, 
        /// то мы должны его переопределить этот базовый родительский метод, 
        /// чтобы добавить в него свой функционал
        /// </summary>
        protected override void OnAppearing()
        {
            /*StackLayout это стопка тарелок, каждая тарелка это какой-то view-элемент, элементы распологаются один под другим,
            никаких связей как в RelativeLayout нам создавать не нужно, потому что они сами по себе находятся один под другим*/

            //Создаем Layout, должно быть подключено пространство using Xamarin.Forms;
            //В данном случае layout будет родительский контейнер для всех элементов которые мы будем создавать далее
            StackLayout layout = new StackLayout();

            //Создаем метку
            Label label1 = new Label();
            //текст который будет отоброжаться в этом контролле
            label1.Text = "Урок 4";
            //цвет текста
            label1.TextColor = Color.Red;
            //размер текста, задается значениями типа double
            label1.FontSize = 20;
            //стиль текста жирный
            label1.FontAttributes = FontAttributes.Bold;
            //центрирование текста
            label1.HorizontalOptions = LayoutOptions.Center;



            //Текстовое поле это класс Entry
            Entry input = new Entry();
            //вводный знак
            input.Placeholder = "Пароль";
            //режим отображения текста как пароль (*******)
            input.IsPassword = true;

            //View элементы очень удобно создавать и инициализировать с помощью инициализатора класса({};)
            //внутрри которых мы можем обращаться к различным свойствам нового экземпляра класса
            Entry input1 = new Entry()
            {
                //нельзя редактировать
                IsEnabled = false,
                Text = "что-то написано",
            };

            //горизонтальный StackLayout
            StackLayout horizontalStack = new StackLayout();
            //делаем StackLayout горизонтальным
            horizontalStack.Orientation = StackOrientation.Horizontal;

            Label sub = new Label()
            {
                Text = "Подписаться",
                FontSize = 25,
                FontAttributes = FontAttributes.Bold
            };

            CheckBox checkBox = new CheckBox()
            {
                //чекбокс сразу будет проставлен
                IsChecked = true,
            };

            //добавляем элементы в горизонтальный стек
            horizontalStack.Children.Add(checkBox);
            horizontalStack.Children.Add(checkBox);

            //добавляем элементы, в коллекцию дочерних элементов StackLayout
            layout.Children.Add(label1);
            layout.Children.Add(input);
            layout.Children.Add(input1);
            layout.Children.Add(horizontalStack);

            //и так как StackLayout должен быть вложен в ContentPage мы не должны про это забыть
            //Контент отоброжаемого StackLayout, в котором содержаться различные контроллы, устанавливаем в Content
            Content = layout;
        }
    }
}
