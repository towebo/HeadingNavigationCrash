using HeadingNavigationCrash.Models;
using System.Collections.ObjectModel;

namespace HeadingNavigationCrash.ViewModels
{
    public class MainViewModel
    {

        public ObservableCollection<ListItem> Items { get; set; }

        public MainViewModel()
        {
            Items = new ObservableCollection<ListItem>();            
        }

        public void InitItems()
        {
            for (int heading_index = 0; heading_index < 20; heading_index++)
            {
                Items.Add(new ListItem() {
                    Title = $"Heading {heading_index + 1}",
                    HeadingLevel = SemanticHeadingLevel.Level2,
                });

                for (int item_index = 0; item_index < 10; item_index++)
                {
                    Items.Add(new ListItem() {
                        Title = $"Item {item_index + 1}",
                        HeadingLevel = SemanticHeadingLevel.None,
                    });
                } // for item_index 
            } // for heading index
        }

    } // class
}
