using System;

namespace ABPFinal{

    public class Song{

        public int SongID {get; set;} // Primary Key

        public string? SongName {get; set;}

        public string? Length {get; set;}
        public string? Genre {get; set;}
        public string? Artist {get; set;}
        public int ListenerID {get; set;}
    }
}