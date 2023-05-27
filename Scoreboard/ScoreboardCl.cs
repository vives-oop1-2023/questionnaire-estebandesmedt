using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using scoreboard;
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

        public void AddPlayerScore(string Playername, string Score, string Filepath)
        {
            string filePath = Filepath;
            List<string> lines = File.ReadAllLines(filePath).ToList();

            lines.Add($"{Playername}: {Score}");
            File.WriteAllLines(filePath, lines );
        }

        public List<Playerscore> GetPlayerScores(string Filepath)
        {
            string filePath = Filepath;
            List<string> scores = File.ReadAllLines(filePath).ToList();

            List<Playerscore> playerscores = new List<Playerscore>();
            foreach (var score in scores)
            {
                string[] entries = score.Split(":");
                if (entries.Length == 2)
                {
                    string name = entries[0].Trim();
                    int scoreValue;
                    if (int.TryParse(entries[1], out scoreValue))
                    {
                        Playerscore playerscore = new Playerscore
                        {
                            Name = name,
                            Score = scoreValue
                        };
                        playerscores.Add(playerscore);
                    }
                }
            }
            return playerscores;
        }



        /* public List<Playerscore> GetPlayerScores()
        {
            string filePath = @"D:\Vives\Fase 1\Semester 2\Object oriented programming\Opdrachten\Questionnaire Final\questionnaire-estebandesmedt\scores.txt";
            List<string> scores = File.ReadAllLines(filePath).ToList();
            
            List<Playerscore> playerscores = new List<Playerscore>();
            foreach(var score in scores)
            {
                string[] entries = score.Split(":");
                Playerscore playerscore = new Playerscore();

                playerscore.Name = entries[0];
                playerscore.Score = Convert.ToInt32(entries[1]);

                playerscores.Add(playerscore);
            }
            return playerscores;
        } */
    }
}

