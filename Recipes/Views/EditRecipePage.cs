using System;

using Xamarin.Forms;

namespace Recipes.Views
{
    public class EditRecipePage : ContentPage
    {
        public EditRecipePage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

