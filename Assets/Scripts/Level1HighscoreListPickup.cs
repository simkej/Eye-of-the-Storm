﻿using UnityEngine;
using System.Collections;
using System.Text;
using System.IO;
using UnityEngine.UI;

public class Level1HighscoreListPickup : MonoBehaviour
{
    string line;

    public int rank;

    void Start()
    {
        if (System.IO.File.Exists("Highscore1.txt"))
        {

            using (StreamReader theReader = new StreamReader("Highscore1.txt", Encoding.Default))
            {
                line = theReader.ReadLine();

                string[] entries = line.Split(';');

                Text text = GetComponent<Text>();
                text.text = "" + entries[rank * 4 - 1];
            }

        }

        else
        {
            Text text = GetComponent<Text>();
            text.text = "0";
        }

    }
}