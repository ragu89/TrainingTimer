using System.Collections.Generic;
using TrainingTimer.Model;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TrainingTimer.UWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        public List<Exercise> Exercises
        {
            get
            {
                return new List<Exercise>()
                {
                    new Exercise() { Name = "Ex 1", Description = "Description 1", Duration = 30F, RepetitionNumber = 3 },
                    new Exercise() { Name = "Ex 2", Description = "Description 2", Duration = 60F, RepetitionNumber = 4 },
                    new Exercise() { Name = "Ex 3", Description = "Description 3", Duration = 30F, RepetitionNumber = 5 },
                };
            }
        }
    }
}
