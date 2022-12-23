namespace CS_Entity_Framework_Players {
    public class Player {
        // CAMPI
        private uint gamesWon;

        // PROPRIETÀ
        [Key]
        public uint PlayerId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public uint Score { get; set; }
        public uint GamesPlayed { get; set; }
        public uint GamesWon {
            get => gamesWon;
            set => gamesWon = ValidGamesWon(value);
        }

        // RELAZIONI


        // COSTRUTTORI


        // METODI PRIVATI
        private uint ValidGamesWon(uint value) {
            if (value > GamesPlayed) {
                throw new ArgumentOutOfRangeException(nameof(value), $"{nameof(value)} cannot be greaten than {nameof(GamesPlayed)}.");
            }

            return value;
        }
    }
}
