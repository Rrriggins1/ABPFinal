using System;

namespace ABPFinal{

    public class Listener{

        public int ListenerID {get; set;}
        public string? FirstName {get; set;}
        public string? LastName {get; set;}
        public string? Major {get; set;}
        public List<Song> SongsList {get; set;} = new List<Song>();
    }
}