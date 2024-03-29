﻿/// ETML 
/// Auteur : Alasfar Ahmad
/// Space Invaders
/// Date : 04.01.2023
/// Class MenuOption : Classe qui a des methode de deplacement et des methodes
/// pour afficher le Menu et les sous-menu

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Space_Invaders
{
    public class MenuOption
    {

        /// <summary>
        /// Default constroctor
        /// </summary>
        public MenuOption()
        {
            
        }

        /// <summary>
        /// play
        /// </summary>
        private const string play = @"     

                                                     _ __  _        _  _ 
                                                    | '_ \| | __ _ | || |
                                                    | .__/| |/ _` | \_. |
                                                    |_|   |_|\__/_| |__/            
        ";

        /// <summary>
        /// Son
        /// </summary>
        private const string SON = @" 
                                                     ___ ___  _ _  
                                                    (_-// _ \| ' \ 
                                                    /__/\___/|_||_|           
        ";

        /// <summary>
        /// DIFFICULTE
        /// </summary>
        private const string DIFFICULTE = @"
                                                        _  _   __   __  _            _  _   
                                                     __| |(_) / _| / _|(_) __  _  _ | || |_ 
                                                    / _` || ||  _||  _|| |/ _|| || || ||  _|
                                                    \__/_||_||_|  |_|  |_|\__| \_._||_| \__|           
        ";

        /// <summary>
        /// SCORES
        /// </summary>
        private const string SCORES = @"          

                                                     ___ __  ___  _ _  ___  ___
                                                    (_-// _|/ _ \| '_|/ -_)(_-/
                                                    /__/\__|\___/|_|  \___|/__/        
        ";

        /// <summary>
        /// EXIT
        /// </summary>
        private const string EXIT = @"
                                                               _  _     ___    
                                                     ___ __ __(_)| |_  |__ \   
                                                    / -_)\ \ /| ||  _|   /_/   
                                                    \___|/_\_\|_| \__|  (_)              
        ";

        /// <summary>
        /// EASY
        /// </summary>
        private const string EASY = @"
                                                      __            _  _      
                                                     / _| __ _  __ (_)| | ___ 
                                                    |  _|/ _` |/ _|| || |/ -_)
                                                    |_|  \__/_|\__||_||_|\___|
           
        ";

        /// <summary>
        /// HARD
        /// </summary>
        private const string HARD = @"
                                                     ___   _   __   __  _      _  _      
                                                    |   \ (_) / _| / _|(_) __ (_)| | ___ 
                                                    | |) || ||  _||  _|| |/ _|| || |/ -_)
                                                    |___/ |_||_|  |_|  |_|\__||_||_|\___|
            
        ";

        /// <summary>
        /// BACK
        /// </summary>
        private const string BACK = @"                 
                                                     _           _   
                                                    | |_ ___ ___| |_ 
                                                    | . | .'|  _| '_|
                                                    |___|__,|___|_,_|                 
        ";

        /// <summary>
        /// ON
        /// </summary>
        private const string ON = @"

                                                     _____ _   _ 
                                                    |  _  | \ | |
                                                    | | | |  \| |
                                                    | | | | . ` |
                                                    \ \_/ / |\  |
                                                     \___/\_| \_/
        ";

        /// <summary>
        /// OFF
        /// </summary>
        private const string OFF = @"
                                                     _________________ 
                                                    |  _  |  ___|  ___|
                                                    | | | | |_  | |_   
                                                    | | | |  _| |  _|  
                                                    \ \_/ / |   | |    
                                                     \___/\_|   \_|    
        ";

        /// <summary>
        /// Position de Y pour le cursor 
        /// </summary>
        public int cursorY = 10;

        /// <summary>
        /// Position de X pour le cursor
        /// </summary>
        public int cursorX = 35;

        /// <summary>
        /// the selected difficulty
        /// </summary>
        private static int _difficulty = 1;

        /// <summary>
        /// the selected son
        /// </summary>
        private static int _son = 2;


        /// <summary>
        /// istancier game
        /// </summary>
        Game game = new Game();                 // objet game

        public static int Difficulty { get => _difficulty; set => _difficulty = value; }



        /// <summary>
        /// methode qui affiche le titre
        /// </summary>
        public void TheTitle()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("V1.0");
            Console.WriteLine(@"     _______ ______        __        ______ _________     _____ ____  _____ ____   ____   __      ________   _________ _______     _______ ");
            Console.WriteLine(@"    /  ___  |_   __ \     /  \     ./ ___  |_   ___  |   |_   _|_   \|_   _|_  _| |_  _| /  \    |_   ___ \.|_   ___  |_   __ \   /  ___  |");
            Console.WriteLine(@"   |  (__ \_| | |__) |   / /\ \   / ./   \_| | |_  \_|     | |   |   \ | |   \ \   / /  / /\ \     | |   \. \ | |_  \_| | |__) | |  (__ \_|");
            Console.WriteLine(@"    '.___\-.  |  ___/   / ____ \  | |        |  _|  _      | |   | |\ \| |    \ \ / /  / ____ \    | |    | | |  _|  _  |  __ /   '.___\-.");
            Console.WriteLine(@"   |\\____) |_| |_    _/ /    \ \_\ \.___.'\_| |___/ |    _| |_ _| |_\   |_    \ ' / _/ /    \ \_ _| |___.' /_| |___/ |_| |  \ \_|\\____) |");
            Console.WriteLine(@"   |_______.'_____|  |____|  |____|\._____.'_________|   |_____|_____|\____|    \_/ |____|  |____|________.'|_________|____| |___|_______.'");

        }

        /// <summary>
        /// methode qui affiche le menu principale
        /// </summary>
        public void PrancipalMenu()
        {
            while (true)
            {
                int i = 0;
                Console.Clear();
                TheTitle();
                Console.ForegroundColor = ConsoleColor.Yellow;

                Console.WriteLine(play);
                Console.WriteLine(SON);
                Console.WriteLine(DIFFICULTE);
                Console.WriteLine(SCORES);
                Console.WriteLine(EXIT);

                // switch qui s'occupe de ce que l'utilisateur a choisi du Menu
                switch (Deplacement(i))
                {
                    case 1:
                        Play();
                        break;

                    case 2:
                        Console.Clear();
                        MenuSon();
                        break;

                    case 3:
                        MenuDifficult();
                        break;

                    case 4:
                        Console.Clear();
                        string scores = File.ReadAllText("../../scores.txt");

                        Console.WriteLine(SCORES + " " + "\n\n\t\t\t\t\t\t\t\t\t" + scores);
                        Console.ReadKey();
                        break;

                    case 5:

                        Environment.Exit(0);

                        break;

                }
            }


        }

        /// <summary>
        /// methode qui fait le deplacement
        /// </summary>
        /// <param name="i"></param>
        /// <returns> la valeur de choisir </returns>
        public int Deplacement(int i)
        {

            Console.SetCursorPosition(cursorX, cursorY);
            Console.Write("==>");

            while (true)
            {

                ConsoleKeyInfo theKey = Console.ReadKey(true);

                // si on tape sur la flèche de bas
                if (theKey.Key == ConsoleKey.DownArrow)
                {
                    // si y est plus que 32 on bloque
                    if (cursorY > 32)
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                    // sinon on descend
                    else
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("   ");
                        cursorY += 6;
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                }

                // si on tape sur la flèche de haut
                if (theKey.Key == ConsoleKey.UpArrow)
                {
                    // si y est moins que 11 on bloque
                    if (cursorY < 11)
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                    // sinon on monte
                    else
                    {
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("   ");
                        cursorY -= 6;
                        Console.SetCursorPosition(cursorX, cursorY);
                        Console.Write("==>");
                    }
                }

                // si on tape sur Enter et on retune des valeurs

                if (theKey.Key == ConsoleKey.Enter && cursorY == 10)
                {
                    i = 1;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 16)
                {
                    i = 2;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 22)
                {
                    i = 3;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 28)
                {
                    i = 4;
                    return i;
                }

                if (theKey.Key == ConsoleKey.Enter && cursorY == 34)
                {
                    i = 5;
                    return i;
                }




            }

        }


        /// <summary>
        /// méthode pour la page de difficulté avec le déplacement
        /// </summary>
        public void MenuDifficult()
        {
            int Y = 10;                // Position de Y pour le cursor de Sous-Menu
            int X = 35;                // Position de X pour le cursor de Sous-Menu
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(DIFFICULTE);

                Console.WriteLine("");


                if (_difficulty == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;

                }

                Console.WriteLine(EASY);

                if (_difficulty == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(HARD);

                Console.SetCursorPosition(25, 30);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(BACK);

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(X, Y);
                Console.Write("==>");


                ConsoleKeyInfo theKey = Console.ReadKey(true);

                // si on tape sur la flèche de bas
                if (theKey.Key == ConsoleKey.DownArrow)
                {
                    // si y est plus que 10 on bloque
                    if (Y > 32)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    // sinon on descend
                    else if (Y == 17)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y += 16;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    else
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y += 7;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                }

                // si on tape sur la flèche de haut
                if (theKey.Key == ConsoleKey.UpArrow)
                {
                    // si y est moins que 11 on bloque
                    if (Y < 11)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    else if (Y == 33)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y -= 16;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    // sinon on monte
                    else
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y -= 7;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                }

                // si je presse Enter dans la page de difficult
                switch (Y)
                {
                    case 10:
                        if (theKey.Key == ConsoleKey.Enter && Y == 10)
                        {

                            _difficulty = 1;
                        }

                        break;

                    case 17:
                        if (theKey.Key == ConsoleKey.Enter && Y == 17)
                        {

                            _difficulty = 2;
                        }
                        break;
                    case 33:
                        if (theKey.Key == ConsoleKey.Enter && Y == 33)
                        {
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.Clear();
                            return;
                        }
                        break;


                }

            }



        }

        /// <summary>
        /// Methode qui appelle la methode de jeu depuis le menu si on tape sur play
        /// </summary>
        public void Play()
        {
            // nettoyer
            Console.Clear();

            // initialiser la page
            Console.SetWindowSize(145, 50);

            // modifier la couleur
            Console.ForegroundColor = ConsoleColor.White;

            // boucle qui se répète si user met pas au moins 2 caractères
            do
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t Au moins 2 caractères");

                // demander le nom
                Console.Write("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\t\t\t\t\t Your name : ");
                game.name = Console.ReadLine();
                Console.Clear();

            } while (game.name.Length < 2);

            game.StartGame();
            



        }


        /// <summary>
        /// méthode pour la page de son avec le déplacement
        /// </summary>
        public void MenuSon()
        {
            int Y = 10;                // Position de Y pour le cursor de Sous-Menu
            int X = 35;                // Position de X pour le cursor de Sous-Menu
            while (true)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(SON);

                Console.WriteLine("");

                // la valeur de son soit 1 
                if (_son == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;

                }

                Console.WriteLine(ON);

                // soit 2
                if (_son == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(OFF);

                Console.SetCursorPosition(25, 30);
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(BACK);

                Console.ForegroundColor = ConsoleColor.White;

                Console.SetCursorPosition(X, Y);
                Console.Write("==>");


                ConsoleKeyInfo theKey = Console.ReadKey(true);

                // si on tape sur la flèche de bas
                if (theKey.Key == ConsoleKey.DownArrow)
                {
                    // si y est plus que 10 on bloque
                    if (Y > 32)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    // sinon on descend
                    else if (Y == 19)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y += 14;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    else
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y += 9;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                }

                // si on tape sur la flèche de haut
                if (theKey.Key == ConsoleKey.UpArrow)
                {
                    // si y est moins que 11 on bloque
                    if (Y < 11)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    else if (Y == 33)
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y -= 14;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                    // sinon on monte
                    else
                    {
                        Console.SetCursorPosition(X, Y);
                        Console.Write("   ");
                        Y -= 9;
                        Console.SetCursorPosition(X, Y);
                        Console.Write("==>");
                    }
                }

                // si je presse Enter dans la page de son
                switch (Y)
                {
                    case 10:
                        if (theKey.Key == ConsoleKey.Enter && Y == 10)
                        {

                            _son = 1;
                        }

                        break;

                    case 19:
                        if (theKey.Key == ConsoleKey.Enter && Y == 19)
                        {

                            _son = 2;
                        }
                        break;
                    case 33:
                        if (theKey.Key == ConsoleKey.Enter && Y == 33)
                        {
                            Console.SetCursorPosition(cursorX, cursorY);
                            Console.Clear();
                            return;
                        }
                        break;


                }

            }



        }



    }
}
