namespace CycleInstructor
{
    public partial class MainPage : ContentPage
    {
        
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        public async Task<FileResult> PickAndShow(PickOptions options)
        {
            try
            {
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
                    {
                        using var stream = await result.OpenReadAsync();
                        var image = ImageSource.FromStream(() => stream);
                    }
                }

                return result;
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }

            return null;
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            count++;
            FileNameLabel.Text = $"You clicked {count} times.";

        }

        private void OnSelectFileClicked(object sender, EventArgs e)
        {
            // Open File selector and set the selected file name to the label FileNameLabel
            var file = DependencyService.Get<IFilePicker>().GetFile();

        }
    }

}
