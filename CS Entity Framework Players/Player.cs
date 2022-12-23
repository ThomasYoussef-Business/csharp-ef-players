namespace CS_Entity_Framework_Players {
    public class Player {
        // CAMPI
        private uint gamesWon;

        // PROPRIETÀ
        [Key]
        public uint PlayerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Precision(5, 3)]
        public double Score { get; set; }
        public uint GamesPlayed { get; set; }
        public uint GamesWon {
            get => gamesWon;
            set => gamesWon = ValidGamesWon(value);
        }

        // RELAZIONI


        // COSTRUTTORI
        public Player(string name, string surname) {
            var rng = new Random();
            Name = name;
            Surname = surname;
            Score = 1 + ((10 - 1) * rng.NextDouble());
            GamesPlayed = (uint)rng.Next(1, 100);
            GamesWon = (uint)rng.Next(1, (int)GamesPlayed);
        }

        // METODI PRIVATI
        private uint ValidGamesWon(uint value) {
            if (value > GamesPlayed) {
                throw new ArgumentOutOfRangeException(nameof(value),
                                                      $"{nameof(value)} cannot be greaten than {nameof(GamesPlayed)}.");
            }

            return value;
        }
    }
}
