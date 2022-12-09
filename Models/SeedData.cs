using Microsoft.EntityFrameworkCore;

namespace ABPFinal{
    public static class SeedData{
        public static void Initialize(IServiceProvider serviceProvider){
            using (var context = new SongContext(
                serviceProvider.GetRequiredService<DbContextOptions<SongContext>>())){
                if (context.Songs.Any()){
                    return;
                }

                context.Songs.AddRange(
                    new Song{
                        SongName = "Bedtime For Bix",
                        Length = "4:19",
                        Genre = "Gypsy Swing",
                        Artist = "Pearl Django",
                        ListenerID = 1
                    },

                    new Song{
                        SongName = "What's Up Fatlip",
                        Length = "3:22",
                        Genre = "Rap",
                        Artist = "Fatlip",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "Absolute Territory",
                        Length = "4:28",
                        Genre = "New Rave",
                        Artist = "Ken Ashcorp",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "That's Life",
                        Length = "3:06",
                        Genre = "Vocal Jazz",
                        Artist = "Frank Sinatra",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "Black Lily",
                        Length = "3:55",
                        Genre = "Indie Rock",
                        Artist = "Ken Ashcorp",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "Come Sweet Death",
                        Length = "5:13",
                        Genre = "Vocal Jazz",
                        Artist = "Platina Jazz",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "Take Me Home",
                        Length = "3:01",
                        Genre = "Rock",
                        Artist = "Ken Ashcorp",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "Fly Me to the Moon",
                        Length = "3:54",
                        Genre = "House",
                        Artist = "Astrophysics",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "Blue",
                        Length = "4:15",
                        Genre = "Indie Rock",
                        Artist = "Ken Ashcorp",
                        ListenerID = 1
                    },
                    new Song{
                        SongName = "From a Place of Love",
                        Length = "3:02",
                        Genre = "Indie",
                        Artist = "Mili",
                        ListenerID = 1
                    }
                );

                context.SaveChanges();
            }
        }
        public static void Initialize2(IServiceProvider serviceProvider){
            using (var context = new ListenerContext(
                serviceProvider.GetRequiredService<DbContextOptions<ListenerContext>>())){
                if (context.Listeners.Any()){
                    return;
                }

                context.Listeners.AddRange(
                    new Listener{
                        FirstName = "Ryan",
                        LastName = "Riggins",
                        Major = "Computer Information Systems"
                    },
                    new Listener{
                        FirstName = "Joe",
                        LastName = "Garrett",
                        Major = "Information Technology"
                    },
                    new Listener{
                        FirstName = "Dylan",
                        LastName = "Green",
                        Major = "Graphic Design"
                    },
                    new Listener{
                        FirstName = "Jordan",
                        LastName = "Conde",
                        Major = "Mass Communications"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}