namespace MineSweeper
{
    using System;
    using System.Collections.Generic;

	public class MineSweeper
	{
        public const int NumberOfRows = 5;
        public const int NumberOfColumns = 10;
	    public const int MaxNumberOfHighScoreResults = 6;
        public const int NumberOfMines = 15;

		public class Results
		{
			private string name;
			private int points;

            public Results()
            {
            }

            public Results(string name, int points)
            {
                this.name = name;
                this.points = points;
            }

			public string Name
			{
				get { return this.name; }
				set { this.name = value; }
			}

			public int Points
			{
                get { return this.points; }
                set { this.points = value; }
			}
		}

		public static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] field = CreatePlayingField();
			char[,] mines = PlaceMines();
			int counter = 0;
			bool exploaded = false;
            List<Results> highScorers = new List<Results>(MaxNumberOfHighScoreResults);
			int row = 0;
			int column = 0;
		    int maxNumberOfTurns = (NumberOfRows * NumberOfColumns) - NumberOfMines;
			bool isNewGame = true;
			bool playerHasWonGame = false;

			do
			{
				if (isNewGame)
				{
					Console.WriteLine("Let's play Minesweeper.\n" + 
                                        "Try out your luck to find the places with no mines.\n\n" +
					                    "The commands are:\n" +
                                        "'top' - show the scoreboard\n" + 
                                        "'restart' - start a new game\n" +
                                        "'exit' - exit the game\n");
					DisplayField(field);
					isNewGame = false;
				}

				Console.Write("Insert row & column: ");
				command = Console.ReadLine().Trim();

				if (command.Length >= 3)
				{
					if (int.TryParse(command[0].ToString(), out row) &&
					    int.TryParse(command[2].ToString(), out column) &&
						row <= field.GetLength(0) && column <= field.GetLength(1))
					{
						command = "turn";
					}
				}

				switch (command)
				{
					case "top":
						ShowHighScores(highScorers);
						break;
					case "restart":
						field = CreatePlayingField();
						mines = PlaceMines();
						DisplayField(field);
						exploaded = false;
						isNewGame = false;
						break;
					case "exit":
						Console.WriteLine("Thank you for playing!");
						break;
					case "turn":
						if (mines[row, column] != '*')
						{
							if (mines[row, column] == '-')
							{
								MakeMove(field, mines, row, column);
								counter++;
							}

                            if (maxNumberOfTurns == counter)
							{
								playerHasWonGame = true;
							}
							else
							{
								DisplayField(field);
							}
						}
						else
						{
							exploaded = true;
						}

						break;
					default:
						Console.WriteLine("\nError! Invalid command!\n");
						break;
				}

				if (exploaded)
				{
					DisplayField(mines);
                    Console.Write(
                                "\nOoops, you died heroically with {0} points. " +
						        "What's your name? ",
                                counter);
					string playerName = Console.ReadLine();
					Results t = new Results(playerName, counter);
					if (highScorers.Count < 5)
					{
						highScorers.Add(t);
					}
					else
					{
						for (int i = 0; i < highScorers.Count; i++)
						{
							if (highScorers[i].Points < t.Points)
							{
								highScorers.Insert(i, t);
								highScorers.RemoveAt(highScorers.Count - 1);
								break;
							}
						}
					}

					highScorers.Sort((Results firstResult, Results secondResult) 
                                    => secondResult.Name.CompareTo(firstResult.Name));
                    highScorers.Sort((Results firstResult, Results secondResult) 
                                    => secondResult.Points.CompareTo(firstResult.Points));
					ShowHighScores(highScorers);

					field = CreatePlayingField();
					mines = PlaceMines();
					counter = 0;
					exploaded = false;
					isNewGame = true;
				}

				if (playerHasWonGame)
				{
					Console.WriteLine("\nWell played! You opened 35 cells without dying. Congratulations!");
					DisplayField(mines);
					Console.WriteLine("What's your name? ");
					string playerName = Console.ReadLine();
					Results result = new Results(playerName, counter);
					highScorers.Add(result);
					ShowHighScores(highScorers);
					field = CreatePlayingField();
					mines = PlaceMines();
					counter = 0;
					playerHasWonGame = false;
					isNewGame = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void ShowHighScores(List<Results> results)
		{
			Console.WriteLine("\nResults:");
			if (results.Count > 0)
			{
				for (int i = 0; i < results.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} boxes", i + 1, results[i].Name, results[i].Points);
				}

				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty scoreboard!\n");
			}
		}

		private static void MakeMove(char[,] field, char[,] mines, int row, int column)
		{
			char numberOfAdjacentMines = NumberOfAdjacentMines(mines, row, column);
			mines[row, column] = numberOfAdjacentMines;
			field[row, column] = numberOfAdjacentMines;
		}

		private static void DisplayField(char[,] board)
		{
			int rows = board.GetLength(0);
			int columns = board.GetLength(1);
			Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
			Console.WriteLine("   ---------------------");
			for (int i = 0; i < rows; i++)
			{
				Console.Write("{0} | ", i);
				for (int j = 0; j < columns; j++)
				{
					Console.Write(string.Format("{0} ", board[i, j]));
				}

				Console.Write("|");
				Console.WriteLine();
			}

			Console.WriteLine("   ---------------------\n");
		}

		private static char[,] CreatePlayingField()
		{
            char[,] board = new char[NumberOfRows, NumberOfColumns];
            for (int i = 0; i < NumberOfRows; i++)
			{
                for (int j = 0; j < NumberOfColumns; j++)
				{
					board[i, j] = '?';
				}
			}

			return board;
		}

		private static char[,] PlaceMines()
		{
            int rows = NumberOfRows;
            int columns = NumberOfColumns;
			char[,] playingField = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					playingField[i, j] = '-';
				}
			}

			List<int> mines = new List<int>();
            while (mines.Count < NumberOfMines)
			{
				Random randomGenerator = new Random();
				int uniqueCellNumber = randomGenerator.Next(NumberOfRows * NumberOfColumns);
				if (!mines.Contains(uniqueCellNumber))
				{
					mines.Add(uniqueCellNumber);
				}
			}

            foreach (int cellNumber in mines)
			{
                int column = (cellNumber / columns);
                int row = (cellNumber % columns);
                if (row == 0 && cellNumber != 0)
				{
					column--;
					row = columns;
				}
				else
				{
					row++;
				}

				playingField[column, row - 1] = '*';
			}

			return playingField;
		}

		private static void FillField(char[,] field)
		{
			int column = field.GetLength(0);
			int row = field.GetLength(1);

			for (int i = 0; i < column; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (field[i, j] != '*')
					{
						char numberOfAdjacentMines = NumberOfAdjacentMines(field, i, j);
                        field[i, j] = numberOfAdjacentMines;
					}
				}
			}
		}

		private static char NumberOfAdjacentMines(char[,] field, int row, int column)
		{
			int adjacentMinesCount = 0;
			int rows = field.GetLength(0);
			int columns = field.GetLength(1);

			if (row - 1 >= 0)
			{
				if (field[row - 1, column] == '*')
				{ 
					adjacentMinesCount++; 
				}
			}

			if (row + 1 < rows)
			{
				if (field[row + 1, column] == '*')
				{ 
					adjacentMinesCount++; 
				}
			}

			if (column - 1 >= 0)
			{
				if (field[row, column - 1] == '*')
				{ 
					adjacentMinesCount++;
				}
			}

			if (column + 1 < columns)
			{
				if (field[row, column + 1] == '*')
				{ 
					adjacentMinesCount++;
				}
			}

			if ((row - 1 >= 0) && (column - 1 >= 0))
			{
				if (field[row - 1, column - 1] == '*')
				{ 
					adjacentMinesCount++; 
				}
			}

			if ((row - 1 >= 0) && (column + 1 < columns))
			{
				if (field[row - 1, column + 1] == '*')
				{ 
					adjacentMinesCount++; 
				}
			}

			if ((row + 1 < rows) && (column - 1 >= 0))
			{
				if (field[row + 1, column - 1] == '*')
				{ 
					adjacentMinesCount++; 
				}
			}

			if ((row + 1 < rows) && (column + 1 < columns))
			{
				if (field[row + 1, column + 1] == '*')
				{ 
					adjacentMinesCount++; 
				}
			}

			return char.Parse(adjacentMinesCount.ToString());
		}
	}
}
