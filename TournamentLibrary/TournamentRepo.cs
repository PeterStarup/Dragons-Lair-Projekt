﻿using System.Collections.Generic;
using System.IO;
namespace TournamentLib
{
    public class TournamentRepo
    {
        //private Tournament winterTournament = new Tournament("Vinter Turnering");

        public Tournament GetTournament(string name)
        {
            //if (name == "Vinter Turnering")
            //{
            //    return winterTournament;
            //}
            //return null;

            StreamReader txtReader = new StreamReader("Gem turneringer.txt");
            string line = txtReader.ReadLine();

            while (line != null) 
            {
                if (line == name) 
                {
                    Tournament tournament = new Tournament(name);
                    return tournament;
                }
                txtReader.Close();
            }
            return null;
        }
    }
}
    
