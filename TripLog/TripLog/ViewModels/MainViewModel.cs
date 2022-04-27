using System;
using System.Collections.ObjectModel;
using TripLog.Models;

namespace TripLog.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        ObservableCollection<TripLogEntry> _logEntries;
        public ObservableCollection<TripLogEntry> LogEntries
        {
            get => _logEntries;
            set
            {
                _logEntries = value;
                OnPropertyChanged();
            }
        }

        public MainViewModel()
        {
            LogEntries = new ObservableCollection<TripLogEntry>
            {

            new TripLogEntry {
                Title = "Grote Kerk Breda",
                Notes = "gebouwd 1410 - 1547, 97 meter hoog",
                Rating = 4,
                Date = new DateTime(2018, 5, 21),
                Latitude = 51.588889,
                Longitude = 4.775278
            },
            new TripLogEntry {
                Title = "Begijnhof Breda",
                Notes = "13e eeuws, naast stadpark valkenberg",
                Rating = 3,
                Date = new DateTime(2019, 2, 28),
                Latitude = 51.588889,
                Longitude = 4.775278
            },
            new TripLogEntry {
                Title = "Mezz popppodium",
                Rating = 4,
                Notes = "Het poppodium bestaat uit een verbouwde officiersmess uit 1899 en een koperen schelpvormige uitbreiding. De Mezz is de opvolger van poppodium Para.",
                Date = new DateTime(2020, 3, 6),
                Latitude = 51.583824,
                Longitude = 4.778921
            },
            new TripLogEntry {
                Title = "Chasse theater en cinema",
                Rating = 4,
                Notes = "Modern gebouw met een opvallend golvend dak naar een ontwerp van Herman Hertzberger",
                Date = new DateTime(2019, 12, 6),
                Latitude = 51.5875,
                Longitude = 4.7822
            },
            new TripLogEntry {
                Title = "Avans Hogeschoollaan",
                Rating = 4,
                Notes = "De place to eat-sleep-learn-repeat",
                Date = new DateTime(2022, 4, 20),
                Latitude = 51.5835,
                Longitude = 4.7964
            },
            new TripLogEntry {
                Title = "Pathe Cinema",
                Rating = 3,
                Notes = "met relax stoelen",
                Date = new DateTime(2020, 4, 20),
                Latitude = 51.5897,
                Longitude = 4.7850
            },
            new TripLogEntry {
                Title = "T-Huis Breda, Valkenbergpark",
                Rating = 4,
                Notes = "Het opvallend gekleurde paviljoen ontworpen door Eindhovense kunstenaar John Körmeling",
                Date = new DateTime(2021, 5, 1),
                Latitude = 51.59200,
                Longitude = 4.78081
            }
        };
        }
    }
}
