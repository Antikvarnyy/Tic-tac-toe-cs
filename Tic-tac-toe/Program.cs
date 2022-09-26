Random random = new Random();
Tic_Tac t = new();
int b = random.Next(1, 3), f = 0;
Console.WriteLine("1 - против компа\n2 - Против игрока\n(первым ходит кто-то случайно)");
int ch = Convert.ToInt32(Console.ReadLine());
Console.Clear();
do
{
	if (ch == 1)
	{
		if (b == 1)
		{
			t.Print();
			Console.WriteLine("Ход человека: ");
			t.X();
			Console.Write("Нажмите что бы продолжить");
			Console.ReadLine();
			Console.Clear();
		}
		else
		{
			Console.WriteLine("Ход Компьютера: ");
			do
			{
				f = 0;
				int a = random.Next(9);
				if (t.cell[a] != 0)
				{
					f++;
				}
				else
				{
					t.cell[a] = 2;
				}

			} while (f != 0);
			t.Print();
			Console.Write("Нажмите что бы продолжить");
			Console.ReadLine();
			Console.Clear();
		}
		if (b == 2)
			b = 1;
		else b = 2;
	}
	else if (ch == 2)
	{
		if (b == 1)
		{
			Console.WriteLine("Ход X: ");
			t.Print();
			t.X();
			Console.Write("Нажмите что бы продолжить");
			Console.ReadLine();
			Console.Clear();
		}
		else
		{
			Console.WriteLine("Ход O: ");
			t.Print();
			t.O();
			Console.Write("Нажмите что бы продолжить");
			Console.ReadLine();
			Console.Clear();
		}
		if (b == 2)
			b = 1;
		else b = 2;

	}
} while (!t.Check());