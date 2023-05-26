using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Formats.Asn1.AsnWriter;

namespace scoreboard
{
    public class ScoreboardCl
    {
        private List<Playerscore> scores = new List<Playerscore>();

        public void AddScore(string name, int score)
        {
            Playerscore playerscore = new Playerscore();

            playerscore.Name = name;
            playerscore.Score = score;

            scores.Add(playerscore);

        }
        public override string ToString()
        {
            string output = "";
            List<Playerscore> sortedScores = scores.OrderByDescending(s => s.Score).ToList();

            for (int i = 0; i < scores.Count; i++)
            {

                output += $" {i + 1} . {sortedScores[i]}  \n";
            }
            return output;
        }
    }
}

