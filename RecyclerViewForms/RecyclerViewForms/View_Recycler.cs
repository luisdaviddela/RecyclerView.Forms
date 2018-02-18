    using Cards;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
namespace RecyclerViewForms
{
    class View_Recycler: ContentPage
    {
        CardData cards = new CardData();
        StackLayout cardstack = new StackLayout
        {
            Spacing = 15,
            Padding = new Thickness(10),
            VerticalOptions = LayoutOptions.StartAndExpand,
        };

        StackLayout shadowcardstack = new StackLayout
        {
            Spacing = 5,
            Padding = new Thickness(5),
            VerticalOptions = LayoutOptions.StartAndExpand,
        };
        public View_Recycler()
        {
            this.Title = "ReclerVier/CardView";
            CargaLista();
            
        }
        public void CargaLista()
        {
            foreach (var card in cards)
            {
                cardstack.Children.Add(new CardView(card));
            }
            this.BackgroundColor = Color.White;
            
            Content = new ScrollView()
            {
                Content = new StackLayout()
                {
                    
                    Spacing=30,
                    Padding=25,
                    Children =
                    {
                            
                            cardstack,
                            shadowcardstack
                    }
                }
            };
            
        }
    }
}
