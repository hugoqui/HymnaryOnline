using HymnaryOnline.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HymnaryOnline.Hubs
{
    public class HymnaryHub : Hub
    {
        public static Song currentSong;

        public void ShowSong(string songName)
        {
            var song = FindSong(songName);
            currentSong = song;
            Clients.All.showSong(song);
        }
        
        public void GetCurrentSong()
        {
            if (currentSong != null)
            {
                Clients.All.showSong(currentSong);
            }
        }

        public void Clear()
        {
            Clients.All.showSong(new Song() { Guitar = "../Content/scores/knees.png", Clarinet = "../Content/scores/knees.png", Piano = "../Content/scores/knees.png", Violin = "../Content/scores/knees.png" });
        }

        Song FindSong(string title)
        {
            foreach (var song in songs)
            {
                if (song.Title == title)
                {
                    return song;
                }
            }
            return new Song();
        }

        public List<Song> songs = new List<Song>()
        {
            new Song(){ Title= "Padre te Amamos",
                Lyrics = "Padre te Amamos y te adoramos. " +
                        "\n Glorifica tu Nombre por toda la tierra." +
                        "\n ///Grofica tu Nombre/// por toda la tierra." ,
                Clarinet = "../Content/scores/clarinet/padre-te-amamos.png",
                Guitar = "../Content/scores/guitar/padre-te-amamos.jpg",
                Violin = "../Content/scores/violin/padre-te-amamos.png"
            },

            new Song(){Title="Santo, Jehová de los Ejércitos",
                Lyrics = "//Santo, Santo, Santo, Jehová de los Ejércitos//" +
                        "\n ///La tierra está llena de tu Gloria///" +
                        "\n Santo es mi Dios." ,
                Clarinet = "../Content/scores/clarinet/santo-jehova-de-los-ejercitos.png",
                Guitar = "../Content/scores/guitar/santo-jehova-de-los-ejercitos.jpg",
                Violin= "../Content/scores/violin/santo-jehova-de-los-ejercitos.png"
            },


            new Song(){Title="Que sea Fiel",
                    Lyrics = "Que sea fiel, fiel, fiel hasta el fin." +
                        "\n Quiero ser fiel, fiel, fiel hasta el fin." +
                        "\n Y cuanto esté en tu Presencia " +
                        "\n Quiero oír Buen Siervo Fiel." +
                        "\n Que sea fiel hasta el fin." ,
            Clarinet = "../Content/scores/clarinet/que-sea-fiel.png",
            Guitar = "../Content/scores/guitar/que-sea-fiel.jpg",
            Violin = "../Content/scores/violin/que-sea-fiel.png"
            }
        };

    }
}