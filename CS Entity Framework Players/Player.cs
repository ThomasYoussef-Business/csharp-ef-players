namespace CS_Entity_Framework_Players {
    public class Player {
        // CAMPI
        private uint gamesWon;
        private double score;

        // PROPRIETÀ
        [Key]
        public uint PlayerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        [Precision(5, 3)]
        public double Score {
            get { return score; }
            set { score = ValidScore(value); }
        }

        public uint GamesPlayed { get; set; }
        public uint GamesWon {
            get => gamesWon;
            set => gamesWon = ValidGamesWon(value);
        }

        // RELAZIONI
        public Team Team { get; set; }

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
        private static double ValidScore(double value) {
            if (value is < 1 or > 10) {
                throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} can only be with 1 and 10. Received {value} instead.");
            }

            return value;
        }
        private uint ValidGamesWon(uint value) {
            if (value > GamesPlayed) {
                throw new ArgumentOutOfRangeException(nameof(value),
                                                      $"{nameof(value)} cannot be greaten than {nameof(GamesPlayed)}.");
            }

            return value;
        }
    }
}
