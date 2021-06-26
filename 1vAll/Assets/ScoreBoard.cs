using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{

    List<string> names = new List<string>();
    List<string> scores = new List<string>();

    public Text Lnames;
    public Text Lscores;

    string filePathNames = "Names.bin";
    string filePathScores = "Scores.bin";

    // Start is called before the first frame update
    void Start()
    {
        
        BinaryReader bwN;
        BinaryReader bwS;

        if (!File.Exists(filePathNames))
            bwN = new BinaryReader(File.Open(filePathNames, FileMode.Create));
        else
            bwN = new BinaryReader(File.Open(filePathNames,FileMode.Open));   
        
        while (bwN.BaseStream.Position < bwN.BaseStream.Length-1)
        {
            names.Add(bwN.ReadString());
        }

        bwN.Close();


        if (!File.Exists(filePathScores))
            bwS = new BinaryReader(File.Open(filePathScores, FileMode.Create));
        else
            bwS = new BinaryReader(File.Open(filePathScores, FileMode.Open));


        while (bwS.BaseStream.Position < bwS.BaseStream.Length)
        {
            scores.Add(bwS.ReadString());
        }
        bwS.Close();

        loadScoreboard();
    }

    //Carrega os dados para as caixas de texto na tabela de recordes
    private void loadScoreboard()
    {
            Lnames.text = names[0] + "\n"+ names[1] + "\n" + names[2] + "\n" + names[3] + "\n" + names[4] + "\n" + names[5] + "\n" + names[6] + "\n" + names[7] + "\n" + names[8] + "\n" + names[9];

            Lscores.text = scores[0] + "\n" + scores[1] + "\n" + scores[2] + "\n" + scores[3] + "\n" + scores[4] + "\n" + scores[5] + "\n" + scores[6] + "\n" + scores[7] + "\n" + scores[8] + "\n" + scores[9]; ;
    }

    //Grava o score do jogador e o nome na lista e depois ordena a lista por ordem crescente de baixo para cima.
    public void SaveScore(int score, string Rnome)
    {
        string temp;

        if (Rnome == "")
            Rnome = "Noob";

        if (int.Parse(scores[scores.Count - 1]) < score)
        {
            scores[scores.Count - 1] = score.ToString();
            names[names.Count - 1] = Rnome;

            for (int i = scores.Count - 1; i > 0; i--)
            {
                for (int j = i-1; j < i ; j++)
                {
                    if (int.Parse(scores[j]) < int.Parse(scores[i]))
                    {
                        temp = scores[i];
                        scores[i] = scores[j];
                        scores[j] = temp;
                        Tnames(i, j);
                    }
                }
            }

            loadScoreboard();
        }
    }

    //Quando e alterada a ordem de um score esta funcao e chamada para trocar os nomes dos scores para estes nao ficarem mal ordenados
    private void Tnames(int i, int j)
    {
        string temp = names[i];
        names[i] = names[j];
        names[j] = temp;
    }

    //Grava as listas nos ficheiros binarios
    public void SaveScores()
    {
        using (BinaryWriter writer = new BinaryWriter(File.Open(filePathNames, FileMode.Open)))
        {
            foreach(string nome in names)
                writer.Write(nome);
        }

        using (BinaryWriter writer = new BinaryWriter(File.Open(filePathScores, FileMode.Open)))
        {
            foreach (string score in scores)
                writer.Write(score);
        }

    }
}
