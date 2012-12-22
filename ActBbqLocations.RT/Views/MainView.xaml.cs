using System.Linq;
using ActBbqLocations.RT.Models;
using Bing.Maps;
using Windows.UI.Xaml.Controls;

namespace ActBbqLocations.RT.Views
{
    public sealed partial class MainView
    {
        public MainView()
        {
            this.InitializeComponent();

            var actLocation = new Location(-35.31129595101126, 149.14213360127565);
            map.ZoomLevel = 12;
            map.Center = actLocation;
            map.SetView(actLocation);    // Workaround: There is an issue with the map. Images won't display until you move the map.

            map.RightTapped += MapRightTapped;  // for debugging
        }

        private void LocationsListOnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (e.AddedItems.Any())
            {
                var clickedBeach = e.AddedItems[0] as LocationData;
                if (clickedBeach != null)
                {
                    map.SetView(new Location(clickedBeach.Latitude, clickedBeach.Longitude), 16);
                }
            }
        }

        void MapRightTapped(object sender, Windows.UI.Xaml.Input.RightTappedRoutedEventArgs e)
        {
            // development helper, allows me to grab coordinates.
            var coordinates = map.Center;
            e.Handled = false; // still allow the app bar to come up.
        }
    }
}
