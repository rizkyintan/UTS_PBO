﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlaylists
{
    public class Lagu
    {
        //Private Attributes
        private string name;
        private string artist;
        /// <summary>
        /// Duration of the Song
        /// </summary>
        private TimeSpan duration;

        //Getters & Setters
        public string Name { get { return this.name; } set { this.name = value; } }

        public String Artists { get { return this.artist; } set { this.artist = value; } }

        public TimeSpan Duration { get { return new TimeSpan(); } set { this.duration = value; } }

        //Constructor
        public Lagu()
        {
            this.name = "Default";
            this.artist = "Default"; 
            this.duration = new TimeSpan(0, 0, 0);
        }
        public Lagu(string name, string artist, TimeSpan duration)
        {
            this.name = name;
            this.artist = artist;
            this.duration = duration;
        }

        public override string ToString()
        {
            return ("Lagu: " + this.name + " \t Artist: " + this.artist + " \t Durasi: " + duration);
        }
    }
}
