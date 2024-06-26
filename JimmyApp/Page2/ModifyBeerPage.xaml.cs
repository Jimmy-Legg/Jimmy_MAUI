namespace JimmyApp
{
    public partial class ModifyBeerPage : ContentPage
    {
        public ModifyBeerPage()
        {
            InitializeComponent();
        }

        private void SaveChanges_Clicked(object sender, EventArgs e)
        {
            var beer = (Beer)BindingContext;
            beer.Name = nameEntry.Text;
            beer.Price = priceEntry.Text;

            double average;
            if (double.TryParse(averageEntry.Text, out average))
            {
                beer.Average = average;
            }

            int reviews;
            if (int.TryParse(reviewsEntry.Text, out reviews))
            {
                beer.Reviews = reviews;
            }

            Navigation.PopAsync();
        }
    }
}
