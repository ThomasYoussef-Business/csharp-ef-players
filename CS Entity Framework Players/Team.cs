namespace CS_Entity_Framework_Players {
    public class Team {
        // PROPRIETÀ
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string Trainer { get; set; }
        // So che questa dovrebbe essere una lista e che dovrei avere una tabella di colori,
        // ma sono quasi le tre di notte, perdonatemi 😭
        public string Colors { get; set; }

        // RELAZIONI
        public List<Player> Players { get; set; }

        // METODI PUBBLICI


        // METODI PRIVATI

    }
}