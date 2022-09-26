class Tic_Tac
{
	public int[] cell = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };


	public bool Check()
	{
		if (cell[0] == 1 && cell[1] == 1 && cell[2] == 1 || cell[3] == 1 && cell[4] == 1 && cell[5] == 1 || cell[6] == 1 && cell[7] == 1 && cell[8] == 1 || cell[0] == 1 && cell[3] == 1 && cell[6] == 1 || cell[1] == 1 && cell[4] == 1 && cell[7] == 1 || cell[2] == 1 && cell[5] == 1 && cell[8] == 1 || cell[0] == 1 && cell[4] == 1 && cell[8] == 1 || cell[6] == 1 && cell[4] == 1 && cell[2] == 1)
		{
			Console.Write("\tX wins!!!\n\n");
			return true;
		}
		else if (cell[0] == 2 && cell[1] == 2 && cell[2] == 2 || cell[3] == 2 && cell[4] == 2 && cell[5] == 2 || cell[6] == 2 && cell[7] == 2 && cell[8] == 2 || cell[0] == 2 && cell[3] == 2 && cell[6] == 2 || cell[1] == 2 && cell[4] == 2 && cell[7] == 2 || cell[2] == 2 && cell[5] == 2 && cell[8] == 2 || cell[0] == 2 && cell[4] == 2 && cell[8] == 2 || cell[6] == 2 && cell[4] == 2 && cell[2] == 2)
		{
			Console.Write("\tO wins!!!\n\n");
			return true;
		}
		else if (cell[0] != 0 && cell[1] != 0 && cell[2] != 0 && cell[3] != 0 && cell[4] != 0 && cell[5] != 0 && cell[6] != 0 && cell[7] != 0 && cell[8] != 0)
		{
			Console.Write("\tDraw\n\n");
			return true;
		}
		else
		{
			return false;
		}
	}
	public void X()
	{
		int n, f = 0;
		do
		{
			f = 0;
			Console.Write("Enter num of space to put X: ");
			n = Convert.ToInt32(Console.ReadLine());
			if (n < 1 || n > 9 || cell[n - 1] == 1 || cell[n - 1] == 2)
			{
				Console.WriteLine("Wrong number");
				f++;
			}
			else
			{
				n--;
				cell[n] = 1;
			}
		} while (f != 0);
	}
	public void O()
	{
		{
			int n, f = 0;
			do
			{
				f = 0;
				Console.Write("Enter num of space to put O: ");
				n = Convert.ToInt32(Console.ReadLine());
				if (n < 1 || n > 9 || cell[n - 1] == 1 || cell[n - 1] == 2)
				{
					Console.WriteLine("Wrong number");
					f++;
				}
				else
				{
					n--;
					cell[n] = 2;
				}
			} while (f != 0);
		}
	}
	public void Print()
	{
		if (cell[0] == 0 && cell[1] == 0 && cell[2] == 0)
		{
			Console.WriteLine("     |     |     \n");
			Console.WriteLine("     |     |     ");
			Console.WriteLine("  1  |  2  |  3  ");
			Console.WriteLine("     |     |     ");
			Console.WriteLine("     |     |     ");
		}
		else if (cell[0] == 1 && cell[1] == 1 && cell[2] == 1)
		{
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine(" X X | X X | X X ");
			Console.WriteLine("  X  |  X  |  X  ");
			Console.WriteLine(" X X | X X | X X ");
			Console.WriteLine("X   X|X   X|X   X");
		}
		else if (cell[0] == 1 && cell[1] == 0 && cell[2] == 0)
		{
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine(" X X |     |     ");
			Console.WriteLine("  X  |  2  |  3  ");
			Console.WriteLine(" X X |     |     ");
			Console.WriteLine("X   X|     |     ");
		}
		else if (cell[0] == 0 && cell[1] == 1 && cell[2] == 0)
		{
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("     | X X |     ");
			Console.WriteLine("  1  |  X  |  3  ");
			Console.WriteLine("     | X X |     ");
			Console.WriteLine("     |X   X|     ");
		}
		else if (cell[0] == 0 && cell[1] == 0 && cell[2] == 1)
		{
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("     |     | X X ");
			Console.WriteLine("  1  |  2  |  X  ");
			Console.WriteLine("     |     | X X ");
			Console.WriteLine("     |     |X   X");
		}
		else if (cell[0] == 1 && cell[1] == 1 && cell[2] == 0)
		{
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine(" X X | X X |     ");
			Console.WriteLine("  X  |  X  |  3  ");
			Console.WriteLine(" X X | X X |     ");
			Console.WriteLine("X   X|X   X|     ");
		}
		else if (cell[0] == 0 && cell[1] == 1 && cell[2] == 1)
		{
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("     | X X | X X ");
			Console.WriteLine("  1  |  X  |  X  ");
			Console.WriteLine("     | X X | X X ");
			Console.WriteLine("     |X   X|X   X");
		}
		else if (cell[0] == 1 && cell[1] == 0 && cell[2] == 1)
		{
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine(" X X |     | X X ");
			Console.WriteLine("  X  |  2  |  X  ");
			Console.WriteLine(" X X |     | X X ");
			Console.WriteLine("X   X|     |X   X");
		}

		else if (cell[0] == 2 && cell[1] == 2 && cell[2] == 2)
		{
			Console.WriteLine(" XXX | XXX | XXX ");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine(" XXX | XXX | XXX ");
		}
		else if (cell[0] == 2 && cell[1] == 0 && cell[2] == 0)
		{
			Console.WriteLine(" XXX |     |     ");
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine("X   X|  2  |  3  ");
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine(" XXX |     |     ");
		}
		else if (cell[0] == 0 && cell[1] == 2 && cell[2] == 0)
		{
			Console.WriteLine("     | XXX |     ");
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("  1  |X   X|  3  ");
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("     | XXX |     ");
		}
		else if (cell[0] == 0 && cell[1] == 0 && cell[2] == 2)
		{
			Console.WriteLine("     |     | XXX ");
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("  1  |  2  |X   X");
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("     |     | XXX ");
		}
		else if (cell[0] == 2 && cell[1] == 2 && cell[2] == 0)
		{
			Console.WriteLine(" XXX | XXX |     ");
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine("X   X|X   X|  3  ");
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine(" XXX | XXX |     ");
		}
		else if (cell[0] == 0 && cell[1] == 2 && cell[2] == 2)
		{
			Console.WriteLine("     | XXX | XXX ");
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("  1  |X   X|X   X");
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("     | XXX | XXX ");
		}
		else if (cell[0] == 2 && cell[1] == 0 && cell[2] == 2)
		{
			Console.WriteLine(" XXX |     | XXX ");
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine("X   X|  2  |X   X");
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine(" XXX |     | XXX ");
		}

		else if (cell[0] == 1 && cell[1] == 0 && cell[2] == 2)
		{
			Console.WriteLine("X   X|     | XXX ");
			Console.WriteLine(" X X |     |X   X");
			Console.WriteLine("  X  |  2  |X   X");
			Console.WriteLine(" X X |     |X   X");
			Console.WriteLine("X   X|     | XXX ");
		}
		else if (cell[0] == 1 && cell[1] == 2 && cell[2] == 0)
		{
			Console.WriteLine("X   X| XXX |     ");
			Console.WriteLine(" X X |X   X|     ");
			Console.WriteLine("  X  |X   X|  3  ");
			Console.WriteLine(" X X |X   X|     ");
			Console.WriteLine("X   X| XXX |     ");
		}
		else if (cell[0] == 1 && cell[1] == 2 && cell[2] == 2)
		{
			Console.WriteLine("X   X| XXX | XXX ");
			Console.WriteLine(" X X |X   X|X   X");
			Console.WriteLine("  X  |X   X|X   X");
			Console.WriteLine(" X X |X   X|X   X");
			Console.WriteLine("X   X| XXX | XXX ");
		}
		else if (cell[0] == 2 && cell[1] == 1 && cell[2] == 2)
		{
			Console.WriteLine(" XXX |X   X| XXX ");
			Console.WriteLine("X   X| X X |X   X");
			Console.WriteLine("X   X|  X  |X   X");
			Console.WriteLine("X   X| X X |X   X");
			Console.WriteLine(" XXX |X   X| XXX ");
		}
		else if (cell[0] == 0 && cell[1] == 1 && cell[2] == 2)
		{
			Console.WriteLine("     |X   X| XXX ");
			Console.WriteLine("     | X X |X   X");
			Console.WriteLine("  1  |  X  |X   X");
			Console.WriteLine("     | X X |X   X");
			Console.WriteLine("     |X   X| XXX ");
		}
		else if (cell[0] == 2 && cell[1] == 1 && cell[2] == 0)
		{
			Console.WriteLine(" XXX |X   X|     ");
			Console.WriteLine("X   X| X X |     ");
			Console.WriteLine("X   X|  X  |  3  ");
			Console.WriteLine("X   X| X X |     ");
			Console.WriteLine(" XXX |X   X|     ");
		}
		else if (cell[0] == 2 && cell[1] == 2 && cell[2] == 1)
		{
			Console.WriteLine(" XXX | XXX |X   X");
			Console.WriteLine("X   X|X   X| X X ");
			Console.WriteLine("X   X|X   X|  X  ");
			Console.WriteLine("X   X|X   X| X X ");
			Console.WriteLine(" XXX | XXX |X   X");
		}
		else if (cell[0] == 0 && cell[1] == 2 && cell[2] == 1)
		{
			Console.WriteLine("     | XXX |X   X");
			Console.WriteLine("     |X   X| X X ");
			Console.WriteLine("  1  |X   X|  X  ");
			Console.WriteLine("     |X   X| X X ");
			Console.WriteLine("     | XXX |X   X");
		}
		else if (cell[0] == 2 && cell[1] == 0 && cell[2] == 1)
		{
			Console.WriteLine(" XXX |     |X   X");
			Console.WriteLine("X   X|     | X X ");
			Console.WriteLine("X   X|  2  |  X  ");
			Console.WriteLine("X   X|     | X X ");
			Console.WriteLine(" XXX |     |X   X");
		}
		else if (cell[0] == 1 && cell[1] == 1 && cell[2] == 2)
		{
			Console.WriteLine("X   X|X   X| XXX ");
			Console.WriteLine(" X X | X X |X   X");
			Console.WriteLine("  X  |  X  |X   X");
			Console.WriteLine(" X X | X X |X   X");
			Console.WriteLine("X   X|X   X| XXX ");
		}
		else if (cell[0] == 2 && cell[1] == 1 && cell[2] == 1)
		{
			Console.WriteLine(" XXX |X   X|X   X");
			Console.WriteLine("X   X| X X | X X ");
			Console.WriteLine("X   X|  X  |  X  ");
			Console.WriteLine("X   X| X X | X X ");
			Console.WriteLine(" XXX |X   X|X   X");
		}
		else if (cell[0] == 1 && cell[1] == 2 && cell[2] == 1)
		{
			Console.WriteLine("X   X| XXX |X   X");
			Console.WriteLine(" X X |X   X| X X ");
			Console.WriteLine("  X  |X   X|  X  ");
			Console.WriteLine(" X X |X   X| X X ");
			Console.WriteLine("X   X| XXX |X   X");
		}
		//////////////////////////////////////////////
		Console.WriteLine("-----------------");
		//////////////////////////////////////////////
		if (cell[3] == 0 && cell[4] == 0 && cell[5] == 0)
		{
			Console.WriteLine("     |     |     ");
			Console.WriteLine("     |     |     ");
			Console.WriteLine("  4  |  5  |  6  ");
			Console.WriteLine("     |     |     ");
			Console.WriteLine("     |     |     ");
		}
		else if (cell[3] == 1 && cell[4] == 1 && cell[5] == 1)
		{
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine(" X X | X X | X X ");
			Console.WriteLine("  X  |  X  |  X  ");
			Console.WriteLine(" X X | X X | X X ");
			Console.WriteLine("X   X|X   X|X   X");
		}
		else if (cell[3] == 1 && cell[4] == 0 && cell[5] == 0)
		{
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine(" X X |     |     ");
			Console.WriteLine("  X  |  5  |  6  ");
			Console.WriteLine(" X X |     |     ");
			Console.WriteLine("X   X|     |     ");
		}
		else if (cell[3] == 0 && cell[4] == 1 && cell[5] == 0)
		{
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("     | X X |     ");
			Console.WriteLine("  4  |  X  |  6  ");
			Console.WriteLine("     | X X |     ");
			Console.WriteLine("     |X   X|     ");
		}
		else if (cell[3] == 0 && cell[4] == 0 && cell[5] == 1)
		{
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("     |     | X X ");
			Console.WriteLine("  4  |  5  |  X  ");
			Console.WriteLine("     |     | X X ");
			Console.WriteLine("     |     |X   X");
		}
		else if (cell[3] == 1 && cell[4] == 1 && cell[5] == 0)
		{
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine(" X X | X X |     ");
			Console.WriteLine("  X  |  X  |  6  ");
			Console.WriteLine(" X X | X X |     ");
			Console.WriteLine("X   X|X   X|     ");
		}
		else if (cell[3] == 0 && cell[4] == 1 && cell[5] == 1)
		{
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("     | X X | X X ");
			Console.WriteLine("  4  |  X  |  X  ");
			Console.WriteLine("     | X X | X X ");
			Console.WriteLine("     |X   X|X   X");
		}
		else if (cell[3] == 1 && cell[4] == 0 && cell[5] == 1)
		{
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine(" X X |     | X X ");
			Console.WriteLine("  X  |  5  |  X  ");
			Console.WriteLine(" X X |     | X X ");
			Console.WriteLine("X   X|     |X   X");
		}

		else if (cell[3] == 2 && cell[4] == 2 && cell[5] == 2)
		{
			Console.WriteLine(" XXX | XXX | XXX ");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine(" XXX | XXX | XXX ");
		}
		else if (cell[3] == 2 && cell[4] == 0 && cell[5] == 0)
		{
			Console.WriteLine(" XXX |     |     ");
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine("X   X|  5  |  6  ");
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine(" XXX |     |     ");
		}
		else if (cell[3] == 0 && cell[4] == 2 && cell[5] == 0)
		{
			Console.WriteLine("     | XXX |     ");
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("  4  |X   X|  6  ");
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("     | XXX |     ");
		}
		else if (cell[3] == 0 && cell[4] == 0 && cell[5] == 2)
		{
			Console.WriteLine("     |     | XXX ");
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("  4  |  5  |X   X");
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("     |     | XXX ");
		}
		else if (cell[3] == 2 && cell[4] == 2 && cell[5] == 0)
		{
			Console.WriteLine(" XXX | XXX |     ");
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine("X   X|X   X|  6  ");
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine(" XXX | XXX |     ");
		}
		else if (cell[3] == 0 && cell[4] == 2 && cell[5] == 2)
		{
			Console.WriteLine("     | XXX | XXX ");
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("  4  |X   X|X   X");
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("     | XXX | XXX ");
		}
		else if (cell[3] == 2 && cell[4] == 0 && cell[5] == 2)
		{
			Console.WriteLine(" XXX |     | XXX ");
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine("X   X|  5  |X   X");
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine(" XXX |     | XXX ");
		}

		else if (cell[3] == 1 && cell[4] == 0 && cell[5] == 2)
		{
			Console.WriteLine("X   X|     | XXX ");
			Console.WriteLine(" X X |     |X   X");
			Console.WriteLine("  X  |  5  |X   X");
			Console.WriteLine(" X X |     |X   X");
			Console.WriteLine("X   X|     | XXX ");
		}
		else if (cell[3] == 1 && cell[4] == 2 && cell[5] == 0)
		{
			Console.WriteLine("X   X| XXX |     ");
			Console.WriteLine(" X X |X   X|     ");
			Console.WriteLine("  X  |X   X|  6  ");
			Console.WriteLine(" X X |X   X|     ");
			Console.WriteLine("X   X| XXX |     ");
		}
		else if (cell[3] == 1 && cell[4] == 2 && cell[5] == 2)
		{
			Console.WriteLine("X   X| XXX | XXX ");
			Console.WriteLine(" X X |X   X|X   X");
			Console.WriteLine("  X  |X   X|X   X");
			Console.WriteLine(" X X |X   X|X   X");
			Console.WriteLine("X   X| XXX | XXX ");
		}
		else if (cell[3] == 2 && cell[4] == 1 && cell[5] == 2)
		{
			Console.WriteLine(" XXX |X   X| XXX ");
			Console.WriteLine("X   X| X X |X   X");
			Console.WriteLine("X   X|  X  |X   X");
			Console.WriteLine("X   X| X X |X   X");
			Console.WriteLine(" XXX |X   X| XXX ");
		}
		else if (cell[3] == 0 && cell[4] == 1 && cell[5] == 2)
		{
			Console.WriteLine("     |X   X| XXX ");
			Console.WriteLine("     | X X |X   X");
			Console.WriteLine("  4  |  X  |X   X");
			Console.WriteLine("     | X X |X   X");
			Console.WriteLine("     |X   X| XXX ");
		}
		else if (cell[3] == 2 && cell[4] == 1 && cell[5] == 0)
		{
			Console.WriteLine(" XXX |X   X|     ");
			Console.WriteLine("X   X| X X |     ");
			Console.WriteLine("X   X|  X  |  6  ");
			Console.WriteLine("X   X| X X |     ");
			Console.WriteLine(" XXX |X   X|     ");
		}
		else if (cell[3] == 2 && cell[4] == 2 && cell[5] == 1)
		{
			Console.WriteLine(" XXX | XXX |X   X");
			Console.WriteLine("X   X|X   X| X X ");
			Console.WriteLine("X   X|X   X|  X  ");
			Console.WriteLine("X   X|X   X| X X ");
			Console.WriteLine(" XXX | XXX |X   X");
		}
		else if (cell[3] == 0 && cell[4] == 2 && cell[5] == 1)
		{
			Console.WriteLine("     | XXX |X   X");
			Console.WriteLine("     |X   X| X X ");
			Console.WriteLine("  4  |X   X|  X  ");
			Console.WriteLine("     |X   X| X X ");
			Console.WriteLine("     | XXX |X   X");
		}
		else if (cell[3] == 2 && cell[4] == 0 && cell[5] == 1)
		{
			Console.WriteLine(" XXX |     |X   X");
			Console.WriteLine("X   X|     | X X ");
			Console.WriteLine("X   X|  5  |  X  ");
			Console.WriteLine("X   X|     | X X ");
			Console.WriteLine(" XXX |     |X   X");
		}
		else if (cell[3] == 1 && cell[4] == 1 && cell[5] == 2)
		{
			Console.WriteLine("X   X|X   X| XXX ");
			Console.WriteLine(" X X | X X |X   X");
			Console.WriteLine("  X  |  X  |X   X");
			Console.WriteLine(" X X | X X |X   X");
			Console.WriteLine("X   X|X   X| XXX ");
		}
		else if (cell[3] == 2 && cell[4] == 1 && cell[5] == 1)
		{
			Console.WriteLine(" XXX |X   X|X   X");
			Console.WriteLine("X   X| X X | X X ");
			Console.WriteLine("X   X|  X  |  X  ");
			Console.WriteLine("X   X| X X | X X ");
			Console.WriteLine(" XXX |X   X|X   X");
		}
		else if (cell[3] == 1 && cell[4] == 2 && cell[5] == 1)
		{
			Console.WriteLine("X   X| XXX |X   X");
			Console.WriteLine(" X X |X   X| X X ");
			Console.WriteLine("  X  |X   X|  X  ");
			Console.WriteLine(" X X |X   X| X X ");
			Console.WriteLine("X   X| XXX |X   X");
		}
		//////////////////////////////////////////////
		Console.WriteLine("-----------------");
		//////////////////////////////////////////////
		if (cell[6] == 0 && cell[7] == 0 && cell[8] == 0)
		{
			Console.WriteLine("     |     |     ");
			Console.WriteLine("     |     |     ");
			Console.WriteLine("  7  |  8  |  9  ");
			Console.WriteLine("     |     |     ");
			Console.WriteLine("     |     |     ");
		}
		else if (cell[6] == 1 && cell[7] == 1 && cell[8] == 1)
		{
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine(" X X | X X | X X ");
			Console.WriteLine("  X  |  X  |  X  ");
			Console.WriteLine(" X X | X X | X X ");
			Console.WriteLine("X   X|X   X|X   X");
		}
		else if (cell[6] == 1 && cell[7] == 0 && cell[8] == 0)
		{
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine(" X X |     |     ");
			Console.WriteLine("  X  |  8  |  9  ");
			Console.WriteLine(" X X |     |     ");
			Console.WriteLine("X   X|     |     ");
		}
		else if (cell[6] == 0 && cell[7] == 1 && cell[8] == 0)
		{
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("     | X X |     ");
			Console.WriteLine("  7  |  X  |  9  ");
			Console.WriteLine("     | X X |     ");
			Console.WriteLine("     |X   X|     ");
		}
		else if (cell[6] == 0 && cell[7] == 0 && cell[8] == 1)
		{
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("     |     | X X ");
			Console.WriteLine("  7  |  8  |  X  ");
			Console.WriteLine("     |     | X X ");
			Console.WriteLine("     |     |X   X");
		}
		else if (cell[6] == 1 && cell[7] == 1 && cell[8] == 0)
		{
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine(" X X | X X |     ");
			Console.WriteLine("  X  |  X  |  9  ");
			Console.WriteLine(" X X | X X |     ");
			Console.WriteLine("X   X|X   X|     ");
		}
		else if (cell[6] == 0 && cell[7] == 1 && cell[8] == 1)
		{
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("     | X X | X X ");
			Console.WriteLine("  7  |  X  |  X  ");
			Console.WriteLine("     | X X | X X ");
			Console.WriteLine("     |X   X|X   X");
		}
		else if (cell[6] == 1 && cell[7] == 0 && cell[8] == 1)
		{
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine(" X X |     | X X ");
			Console.WriteLine("  X  |  8  |  X  ");
			Console.WriteLine(" X X |     | X X ");
			Console.WriteLine("X   X|     |X   X");
		}

		else if (cell[6] == 2 && cell[7] == 2 && cell[8] == 2)
		{
			Console.WriteLine(" XXX | XXX | XXX ");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine("X   X|X   X|X   X");
			Console.WriteLine(" XXX | XXX | XXX ");
		}
		else if (cell[6] == 2 && cell[7] == 0 && cell[8] == 0)
		{
			Console.WriteLine(" XXX |     |     ");
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine("X   X|  8  |  9  ");
			Console.WriteLine("X   X|     |     ");
			Console.WriteLine(" XXX |     |     ");
		}
		else if (cell[6] == 0 && cell[7] == 2 && cell[8] == 0)
		{
			Console.WriteLine("     | XXX |     ");
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("  7  |X   X|  9  ");
			Console.WriteLine("     |X   X|     ");
			Console.WriteLine("     | XXX |     ");
		}
		else if (cell[6] == 0 && cell[7] == 0 && cell[8] == 2)
		{
			Console.WriteLine("     |     | XXX ");
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("  7  |  8  |X   X");
			Console.WriteLine("     |     |X   X");
			Console.WriteLine("     |     | XXX ");
		}
		else if (cell[6] == 2 && cell[7] == 2 && cell[8] == 0)
		{
			Console.WriteLine(" XXX | XXX |     ");
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine("X   X|X   X|  9  ");
			Console.WriteLine("X   X|X   X|     ");
			Console.WriteLine(" XXX | XXX |     ");
		}
		else if (cell[6] == 0 && cell[7] == 2 && cell[8] == 2)
		{
			Console.WriteLine("     | XXX | XXX ");
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("  7  |X   X|X   X");
			Console.WriteLine("     |X   X|X   X");
			Console.WriteLine("     | XXX | XXX ");
		}
		else if (cell[6] == 2 && cell[7] == 0 && cell[8] == 2)
		{
			Console.WriteLine(" XXX |     | XXX ");
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine("X   X|  8  |X   X");
			Console.WriteLine("X   X|     |X   X");
			Console.WriteLine(" XXX |     | XXX ");
		}

		else if (cell[6] == 1 && cell[7] == 0 && cell[8] == 2)
		{
			Console.WriteLine("X   X|     | XXX ");
			Console.WriteLine(" X X |     |X   X");
			Console.WriteLine("  X  |  8  |X   X");
			Console.WriteLine(" X X |     |X   X");
			Console.WriteLine("X   X|     | XXX ");
		}
		else if (cell[6] == 1 && cell[7] == 2 && cell[8] == 0)
		{
			Console.WriteLine("X   X| XXX |     ");
			Console.WriteLine(" X X |X   X|     ");
			Console.WriteLine("  X  |X   X|  9  ");
			Console.WriteLine(" X X |X   X|     ");
			Console.WriteLine("X   X| XXX |     ");
		}
		else if (cell[6] == 1 && cell[7] == 2 && cell[8] == 2)
		{
			Console.WriteLine("X   X| XXX | XXX ");
			Console.WriteLine(" X X |X   X|X   X");
			Console.WriteLine("  X  |X   X|X   X");
			Console.WriteLine(" X X |X   X|X   X");
			Console.WriteLine("X   X| XXX | XXX ");
		}
		else if (cell[6] == 2 && cell[7] == 1 && cell[8] == 2)
		{
			Console.WriteLine(" XXX |X   X| XXX ");
			Console.WriteLine("X   X| X X |X   X");
			Console.WriteLine("X   X|  X  |X   X");
			Console.WriteLine("X   X| X X |X   X");
			Console.WriteLine(" XXX |X   X| XXX ");
		}
		else if (cell[6] == 0 && cell[7] == 1 && cell[8] == 2)
		{
			Console.WriteLine("     |X   X| XXX ");
			Console.WriteLine("     | X X |X   X");
			Console.WriteLine("  7  |  X  |X   X");
			Console.WriteLine("     | X X |X   X");
			Console.WriteLine("     |X   X| XXX ");
		}
		else if (cell[6] == 2 && cell[7] == 1 && cell[8] == 0)
		{
			Console.WriteLine(" XXX |X   X|     ");
			Console.WriteLine("X   X| X X |     ");
			Console.WriteLine("X   X|  X  |  9  ");
			Console.WriteLine("X   X| X X |     ");
			Console.WriteLine(" XXX |X   X|     ");
		}
		else if (cell[6] == 2 && cell[7] == 2 && cell[8] == 1)
		{
			Console.WriteLine(" XXX | XXX |X   X");
			Console.WriteLine("X   X|X   X| X X ");
			Console.WriteLine("X   X|X   X|  X  ");
			Console.WriteLine("X   X|X   X| X X ");
			Console.WriteLine(" XXX | XXX |X   X");
		}
		else if (cell[6] == 0 && cell[7] == 2 && cell[8] == 1)
		{
			Console.WriteLine("     | XXX |X   X");
			Console.WriteLine("     |X   X| X X ");
			Console.WriteLine("  7  |X   X|  X  ");
			Console.WriteLine("     |X   X| X X ");
			Console.WriteLine("     | XXX |X   X");
		}
		else if (cell[6] == 2 && cell[7] == 0 && cell[8] == 1)
		{
			Console.WriteLine(" XXX |     |X   X");
			Console.WriteLine("X   X|     | X X ");
			Console.WriteLine("X   X|  8  |  X  ");
			Console.WriteLine("X   X|     | X X ");
			Console.WriteLine(" XXX |     |X   X");
		}
		else if (cell[6] == 1 && cell[7] == 1 && cell[8] == 2)
		{
			Console.WriteLine("X   X|X   X| XXX ");
			Console.WriteLine(" X X | X X |X   X");
			Console.WriteLine("  X  |  X  |X   X");
			Console.WriteLine(" X X | X X |X   X");
			Console.WriteLine("X   X|X   X| XXX ");
		}
		else if (cell[6] == 2 && cell[7] == 1 && cell[8] == 1)
		{
			Console.WriteLine(" XXX |X   X|X   X");
			Console.WriteLine("X   X| X X | X X ");
			Console.WriteLine("X   X|  X  |  X  ");
			Console.WriteLine("X   X| X X | X X ");
			Console.WriteLine(" XXX |X   X|X   X");
		}
		else if (cell[6] == 1 && cell[7] == 2 && cell[8] == 1)
		{
			Console.WriteLine("X   X| XXX |X   X");
			Console.WriteLine(" X X |X   X| X X ");
			Console.WriteLine("  X  |X   X|  X  ");
			Console.WriteLine(" X X |X   X| X X ");
			Console.WriteLine("X   X| XXX |X   X");
		}
	}

};