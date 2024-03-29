﻿/// ETML 
/// Auteur : Alasfar Ahmad
/// Space Invaders
/// Date : 04.01.2023
/// Class Alien : Classe qui a des methode de alien avec le symboles et les methodes
/// pour les afficher et supprimer

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Space_Invaders
{
    public class Alien
    {
        /// <summary>
        /// La position y de alien
        /// </summary>
        private int _y;

        /// <summary>
        /// la position x de alien
        /// </summary>
        private int _x;


        /// <summary>
        /// tableau du symbole d'alien
        /// </summary>
        private static string[] _symbol = new string[6]               
        {      "             ",
               "   ▀▄   ▄▀   ",
               "  ▄█▀███▀█▄  ",
               " █▀███████▀█ ",
               " █ █▀▀▀▀▀█ █ ",
               "    ▀▀ ▀▀    "
        };

        /// <summary>
        /// tableau du symbole vide
        /// </summary>
        private static string[] _noSymbol = new string[6]                // tableau du symbole
        {
               "             ",
               "             ",
               "             ",
               "             ",
               "             ",
               "             "
        };

        /// <summary>
        /// Default constroctor
        /// </summary>
        public Alien(int X, int Y)
        {
            _x = X;
            _y = Y;
        }

        /// <summary>
        /// Getting setting de la position X
        /// </summary>
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        /// <summary>
        /// Getting setting de la position Y
        /// </summary>
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }


        /// <summary>
        /// méthode pour dessiner l'alien
        /// </summary>
        public void DrawAlien()
        {
            for (int i = 0; i < _symbol.Length; i++)
            {

                for (int g = 0; g < _symbol[i].Length; g++)
                {
                    Console.SetCursorPosition(X + g, Y + i);
                    Console.WriteLine(_symbol[i][g]);
                }
            }
        }


        /// <summary>
        /// méthode pour Supprimer Canon
        /// </summary>
        public void DeleteAlien()
        {
            for (int i = 0; i < _noSymbol.Length; i++)
            {

                for (int g = 0; g < _noSymbol[i].Length; g++)
                {
                    Console.SetCursorPosition(X + g, Y + i);
                    Console.WriteLine(_noSymbol[i][g]);
                }
            }
        }

    }
}
