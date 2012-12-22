using System;
using System.Collections.Generic;
using System.Linq;
using ActBbqLocations.RT.Helpers;
using ActBbqLocations.RT.Models;

namespace ActBbqLocations.RT.ViewModels
{
    public class MainViewModel
    {
        public SortedObservableCollection<LocationData> Locations { get; set; }

        public MainViewModel()
        {
            Locations = new SortedObservableCollection<LocationData>();

            CreateData();
        }

        private void CreateData()
        {
            Locations.Add(new LocationData { LocationName = "Point Hut District Park", Latitude = -35.4558089566667, Longitude = 149.084306383611 });
            Locations.Add(new LocationData { LocationName = "Rememberance Park", Latitude = -35.2798894361111, Longitude = 149.151006531667 });
            Locations.Add(new LocationData { LocationName = "Rememberance Park", Latitude = -35.279479055, Longitude = 149.151268717778 });
            Locations.Add(new LocationData { LocationName = "Edison District Park", Latitude = -35.3413403772222, Longitude = 149.090263742778 });
            Locations.Add(new LocationData { LocationName = "Edison District Park", Latitude = -35.3413623788889, Longitude = 149.090041595278 });
            Locations.Add(new LocationData { LocationName = "Phillip Town Centre", Latitude = -35.3450589936111, Longitude = 149.083156956667 });
            Locations.Add(new LocationData { LocationName = "Phillip Town Centre", Latitude = -35.3448118941667, Longitude = 149.086913709444 });
            Locations.Add(new LocationData { LocationName = "Groom Street - Pedestrian Parkland", Latitude = -35.3328748083333, Longitude = 149.08897375 });
            Locations.Add(new LocationData { LocationName = "Araluen Street - Neighbourhood Park", Latitude = -35.3606224752778, Longitude = 149.057287935 });
            Locations.Add(new LocationData { LocationName = "Lowanna Street - Neighbourhood Park", Latitude = -35.2648292088889, Longitude = 149.133249054167 });
            Locations.Add(new LocationData { LocationName = "Lowanna Street - Neighbourhood Park", Latitude = -35.2641967638889, Longitude = 149.133978978889 });
            Locations.Add(new LocationData { LocationName = "Haig Park", Latitude = -35.2696807291667, Longitude = 149.1284422675 });
            Locations.Add(new LocationData { LocationName = "Haig Park", Latitude = -35.2689325608333, Longitude = 149.126529398611 });
            Locations.Add(new LocationData { LocationName = "Corroboree Park", Latitude = -35.2690243916667, Longitude = 149.142367264722 });
            Locations.Add(new LocationData { LocationName = "Glebe Park", Latitude = -35.28353588, Longitude = 149.136387352778 });
            Locations.Add(new LocationData { LocationName = "Glebe Park", Latitude = -35.2823952269444, Longitude = 149.136645950278 });
            Locations.Add(new LocationData { LocationName = "Glebe Park", Latitude = -35.2818903794444, Longitude = 149.136340452222 });
            Locations.Add(new LocationData { LocationName = "Molonglo Reach District Park", Latitude = -35.3045930930556, Longitude = 149.167365951667 });
            Locations.Add(new LocationData { LocationName = "Black Mountain Peninsula District Park", Latitude = -35.2871874030556, Longitude = 149.101433693333 });
            Locations.Add(new LocationData { LocationName = "Black Mountain Peninsula District Park", Latitude = -35.2922566155556, Longitude = 149.099583376389 });
            Locations.Add(new LocationData { LocationName = "Black Mountain Peninsula District Park", Latitude = -35.2916060963889, Longitude = 149.1001386675 });
            Locations.Add(new LocationData { LocationName = "Black Mountain Peninsula District Park", Latitude = -35.2921850475, Longitude = 149.100972848333 });
            Locations.Add(new LocationData { LocationName = "Acton Park District Park", Latitude = -35.2863102275, Longitude = 149.124722943889 });
            Locations.Add(new LocationData { LocationName = "Acton Park District Park", Latitude = -35.2862210494444, Longitude = 149.124393686111 });
            Locations.Add(new LocationData { LocationName = "Ginninderra Peninsula District Park", Latitude = -35.2290348625, Longitude = 149.074213433056 });
            Locations.Add(new LocationData { LocationName = "Diddams Close Pedestrian Parkland", Latitude = -35.2291368633333, Longitude = 149.074018669722 });
            Locations.Add(new LocationData { LocationName = "Joynton Smith Drive Pedestrian Parkland", Latitude = -35.2278958597222, Longitude = 149.062728267778 });
            Locations.Add(new LocationData { LocationName = "Lake Ginninderra Western Foreshores", Latitude = -35.2274651072222, Longitude = 149.063448482222 });
            Locations.Add(new LocationData { LocationName = "Lake Ginninderra Western Foreshores", Latitude = -35.2272830152778, Longitude = 149.063379452222 });
            Locations.Add(new LocationData { LocationName = "Lake Ginninderra Western Foreshores", Latitude = -35.2272381155556, Longitude = 149.063186640833 });
            Locations.Add(new LocationData { LocationName = "Lake Ginninderra Western Foreshores", Latitude = -35.2259402141667, Longitude = 149.0632299225 });
            Locations.Add(new LocationData { LocationName = "Lake Ginninderra Western Foreshores", Latitude = -35.2247099822222, Longitude = 149.062822961944 });
            Locations.Add(new LocationData { LocationName = "Totterdell Street Pedestrian Parkland", Latitude = -35.2324267725, Longitude = 149.060281999444 });
            Locations.Add(new LocationData { LocationName = "Ginninderra Peninsula District Park", Latitude = -35.2257341958333, Longitude = 149.069600325 });
            Locations.Add(new LocationData { LocationName = "Ginninderra Peninsula District Park", Latitude = -35.2258126394444, Longitude = 149.069420674444 });
            Locations.Add(new LocationData { LocationName = "John Knight Memorial Park", Latitude = -35.2343980625, Longitude = 149.073377714444 });
            Locations.Add(new LocationData { LocationName = "John Knight Memorial Park", Latitude = -35.2347513283333, Longitude = 149.073363548889 });
            Locations.Add(new LocationData { LocationName = "Carlile Street Pedestrian Parkland", Latitude = -35.2180572947222, Longitude = 149.067104296389 });
            Locations.Add(new LocationData { LocationName = "Tattersall Crescent Neighbourhood Park", Latitude = -35.2235855811111, Longitude = 149.056927736667 });
            Locations.Add(new LocationData { LocationName = "Hall Park", Latitude = -35.1721257663889, Longitude = 149.069700832778 });
            Locations.Add(new LocationData { LocationName = "Hall Park", Latitude = -35.1717891825, Longitude = 149.069784489167 });
            Locations.Add(new LocationData { LocationName = "Umbagong District Park", Latitude = -35.2116579463889, Longitude = 149.031092601667 });
            Locations.Add(new LocationData { LocationName = "Umbagong District Park", Latitude = -35.2157605647222, Longitude = 149.028852577778 });
            Locations.Add(new LocationData { LocationName = "Umbagong District Park", Latitude = -35.2160004736111, Longitude = 149.028984936667 });
            Locations.Add(new LocationData { LocationName = "Marks Place Pedestrian Parkland", Latitude = -35.2080163841667, Longitude = 149.014098287778 });
            Locations.Add(new LocationData { LocationName = "Harper Street Pedestrian Parkland", Latitude = -35.2133183294444, Longitude = 149.014794955556 });
            Locations.Add(new LocationData { LocationName = "Palmerville Heritage Park", Latitude = -35.2120299963889, Longitude = 149.085740790278 });
            Locations.Add(new LocationData { LocationName = "Palmerville Heritage Park", Latitude = -35.211767665, Longitude = 149.085556159167 });
            Locations.Add(new LocationData { LocationName = "Yerrabi District Park", Latitude = -35.1793904788889, Longitude = 149.130639860833 });
            Locations.Add(new LocationData { LocationName = "Yerrabi District Park", Latitude = -35.1792691463889, Longitude = 149.130874825 });
            Locations.Add(new LocationData { LocationName = "Yerrabi District Park", Latitude = -35.1792068313889, Longitude = 149.1308299625 });
            Locations.Add(new LocationData { LocationName = "Yerrabi District Park", Latitude = -35.1793595677778, Longitude = 149.130603368611 });
            Locations.Add(new LocationData { LocationName = "Baillieu Lane Pedestrian Parkland", Latitude = -35.2179286372222, Longitude = 149.142185953333 });
            Locations.Add(new LocationData { LocationName = "Griffin Place - Pedestrian Parkland", Latitude = -35.4184729152778, Longitude = 149.083942389722 });
            Locations.Add(new LocationData { LocationName = "Newman-Morris Circuit - Neighbourhood Park", Latitude = -35.4065853044444, Longitude = 149.078788351944 });
            Locations.Add(new LocationData { LocationName = "Kambah District Park", Latitude = -35.3886602452778, Longitude = 149.060530320556 });
            Locations.Add(new LocationData { LocationName = "Kambah District Park", Latitude = -35.3885965008333, Longitude = 149.060430361111 });
            Locations.Add(new LocationData { LocationName = "Kambah District Park", Latitude = -35.3918625694444, Longitude = 149.062140881667 });
            Locations.Add(new LocationData { LocationName = "Kambah District Park", Latitude = -35.3920610908333, Longitude = 149.062086563333 });
            Locations.Add(new LocationData { LocationName = "Kambah District Park", Latitude = -35.3921776216667, Longitude = 149.062021864167 });
            Locations.Add(new LocationData { LocationName = "Tuggeranong Town Park", Latitude = -35.4107607772222, Longitude = 149.064733734167 });
            Locations.Add(new LocationData { LocationName = "Point Hut District Park", Latitude = -35.4560405747222, Longitude = 149.084697139722 });
            Locations.Add(new LocationData { LocationName = "Maryborough Street - Pedestrian Parkland", Latitude = -35.3268016591667, Longitude = 149.176660696944 });
            Locations.Add(new LocationData { LocationName = "Maryborough Street - Pedestrian Parkland", Latitude = -35.3268377869444, Longitude = 149.176578630833 });
            Locations.Add(new LocationData { LocationName = "Bedford Street - Neighbourhood Park", Latitude = -35.3182257413889, Longitude = 149.112073273889 });
            Locations.Add(new LocationData { LocationName = "Telopea Park", Latitude = -35.315636485, Longitude = 149.137298353611 });
            Locations.Add(new LocationData { LocationName = "Telopea Park", Latitude = -35.3155521886111, Longitude = 149.137199743611 });
            Locations.Add(new LocationData { LocationName = "Telopea Park", Latitude = -35.3148750583333, Longitude = 149.1377928025 });
            Locations.Add(new LocationData { LocationName = "Telopea Park", Latitude = -35.3111162605556, Longitude = 149.140144977778 });
            Locations.Add(new LocationData { LocationName = "Telopea Park", Latitude = -35.2818903794444, Longitude = 149.136340452222 });
            Locations.Add(new LocationData { LocationName = "Alexandrina Drive - Pedestrian Parkland", Latitude = -35.2978663536111, Longitude = 149.109266522778 });
            Locations.Add(new LocationData { LocationName = "Alexandrina Drive - Pedestrian Parkland", Latitude = -35.2987434661111, Longitude = 149.110603686389 });
            Locations.Add(new LocationData { LocationName = "Lennox Gardens", Latitude = -35.2989592333333, Longitude = 149.121082224722 });
            Locations.Add(new LocationData { LocationName = "Lennox Gardens", Latitude = -35.2990462227778, Longitude = 149.121452165 });
            Locations.Add(new LocationData { LocationName = "Lennox Gardens", Latitude = -35.2984784616667, Longitude = 149.121806358889 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2957272672222, Longitude = 149.095152656111 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2937265158333, Longitude = 149.093392905278 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2913868886111, Longitude = 149.090181638889 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2925320763889, Longitude = 149.093198696667 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2908463258333, Longitude = 149.091178743333 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2902876805556, Longitude = 149.092154201944 });
            Locations.Add(new LocationData { LocationName = "Weston Park", Latitude = -35.2900038886111, Longitude = 149.095470733611 });
            Locations.Add(new LocationData { LocationName = "Ellenborough Street - Pedestrian Parkland", Latitude = -35.2406795019444, Longitude = 149.124022163889 });
            Locations.Add(new LocationData { LocationName = "John Knight Memorial Park", Latitude = -35.2378776122222, Longitude = 149.074245074444 });
            Locations.Add(new LocationData { LocationName = "John Knight Memorial Park", Latitude = -35.2378608791667, Longitude = 149.074205472778 });
            Locations.Add(new LocationData { LocationName = "Victoria Street Road Verge", Latitude = -35.1614151169444, Longitude = 149.063107794722 });
            Locations.Add(new LocationData { LocationName = "Fadden Pines District Park", Latitude = -35.4116606102778, Longitude = 149.120235975 });
            Locations.Add(new LocationData { LocationName = "Fadden Pines District Park", Latitude = -35.4104198302778, Longitude = 149.120029539167 });
            Locations.Add(new LocationData { LocationName = "Fadden Pines District Park", Latitude = -35.4109169283333, Longitude = 149.119364137778 });
            Locations.Add(new LocationData { LocationName = "Fadden Pines District Park", Latitude = -35.4112931583333, Longitude = 149.121089246944 });
            Locations.Add(new LocationData { LocationName = "Candlebark Close Neighbourhood Park", Latitude = -35.1924169894444, Longitude = 149.110003771667 });
            Locations.Add(new LocationData { LocationName = "Candlebark Close Neighbourhood Park", Latitude = -35.1920397338889, Longitude = 149.110137864722 });
            Locations.Add(new LocationData { LocationName = "Tuggeranong Town Park", Latitude = -35.4099061019444, Longitude = 149.065091572778 });
            Locations.Add(new LocationData { LocationName = "Lake Tuggeranong District Park", Latitude = -35.4084348838889, Longitude = 149.069792675556 });
            Locations.Add(new LocationData { LocationName = "Lake Tuggeranong District Park", Latitude = -35.4072201472222, Longitude = 149.070569910833 });
            Locations.Add(new LocationData { LocationName = "Lake Tuggeranong District Park", Latitude = -35.4051803430556, Longitude = 149.071506821111 });
        }
    }
}
