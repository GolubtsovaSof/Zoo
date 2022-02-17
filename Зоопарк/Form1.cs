using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Зоопарк
{
	public partial class Form1 : Form
	{
		public string n;
		List<Animal> Animals = new List<Animal>();
		List<Button> buttons = new List<Button>();
		List<Button> AbButtons = new List<Button>();

		int IndChosen;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			AbButtons.Add(button7); AbButtons.Add(button8); AbButtons.Add(button9); AbButtons.Add(button10);
		}
		abstract class Animal
		{
			protected string Name;
			public Animal (string n)
			{
				Name = n;
			}
			public abstract string Talk();
		}
		interface IFly
		{
			string Fly();
		}
		interface IRun
		{
			string Run();
		}
		interface ISwim
		{
			string Swim();
		}
		class Croc : Animal, ISwim, IRun
		{
			public Croc(string name) : base(name) { }
			public string Swim()
			{ return "Крокодил " + Name + " поплыл(а)!"; }
			public string Run()
			{ return "Крокодил " + Name + " побежал(а)!"; }
			public override string Talk()
			{ return "Привет, я крокодил " + Name + "!"; }
		}
		class Fish : Animal, ISwim
		{
			public Fish(string name) : base(name) { }
			public string Swim()
			{ return "Рыба " + Name + " поплыл(а)!"; }
			public override string Talk()
			{ return "Рыба " + Name + " говорит: ''bool bool bool. Знаете, почему рыба не клюет? Потому что у нее нет клюва...''"; }
		}
		class Mouse : Animal, IRun, ISwim
		{
			public Mouse(string name) : base(name) { }
			public string Run()
			{ return "Мышь " + Name + " побежал(а)!"; }
			public string Swim()
			{ return "Мышь " + Name + " поплыл(а)!"; }
			public override string Talk()
			{ return "Мышь "+Name+" говорит: ''3,14 3,14 3,14. Мужчины как мыши: отдельно смотришь — трогательный зверек, а как заведется дома — хочется отравить.''"; }
		}
		class Eagle : Animal, IFly
		{
			public Eagle(string name) : base(name) { }
			public string Fly()
			{ return "Орел " + Name + " полетел(а)!"; }
			public override string Talk()
			{ return "Орел " + Name + " говорит: ''Женщины, запомните: сколько времени на дятла не тратить - орла всё равно из него не сделаешь.''"; }
		}
		class Eleph : Animal, IRun, ISwim
		{
			public Eleph(string name) : base(name) { }
			public string Run()
			{ return "Слон " + Name + " побежал(а)!"; }
			public string Swim()
			{ return "Слон " + Name + " поплыл(а)!"; }
			public override string Talk()
			{ return "Слон " + Name + " говорит: ''Видел в цирке слона. Так вот, нихрена он не ходит по диагонали!''"; }
		}
		class Duck : Animal, IRun, ISwim, IFly
		{
			public Duck(string name) : base(name) { }
			public string Run()
			{ return "Утка " + Name + " побежала(а)!"; }
			public string Swim()
			{ return "Утка " + Name + " поплыл(а)!"; }
			public string Fly()
			{ return "Утка " + Name + " полетел(а)!"; }
			public override string Talk()
			{ return "Утка " + Name + " говорит: ''Возвращаются мужики с охоты. — Да—а, не пошла сегодня чего—то охота! — Да—а—а... То ли утки высоко летали, то ли мы собаку низко подбрасывали...''"; }
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			n = f2.n;
			Croc croc = new Croc(n);
			Animals.Add(croc);
			Button b = new Button();
			b.Text = "Крокодил "+n;
			b.Width = 200;
			buttons.Add(b);
			AddButton(b);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			n = f2.n;
			Fish fish = new Fish(n);
			Animals.Add(fish);
			Button b = new Button();
			b.Text = "Рыба " + n;
			b.Width = 200;
			buttons.Add(b);
			AddButton(b);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			n = f2.n;
			Mouse mouse = new Mouse(n);
			Animals.Add(mouse);
			Button b = new Button();
			b.Text = "Мышь " + n;
			b.Width = 200;
			buttons.Add(b);
			AddButton(b);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			n = f2.n;
			Eagle eagle = new Eagle(n);
			Animals.Add(eagle);
			Button b = new Button();
			b.Text = "Орел " + n;
			b.Width = 200;
			buttons.Add(b);
			AddButton(b);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			n = f2.n;
			Eleph eleph = new Eleph(n);
			Animals.Add(eleph);
			Button b = new Button();
			b.Text = "Слон " + n;
			b.Width = 200;
			buttons.Add(b);
			AddButton(b);
		}

		private void button6_Click(object sender, EventArgs e)
		{
			Form2 f2 = new Form2();
			f2.ShowDialog();
			n = f2.n;
			Duck duck = new Duck(n);
			Animals.Add(duck);
			Button b = new Button();
			b.Text = "Утка " + n;
			b.Width = 200;
			buttons.Add(b);
			AddButton(b);
		}
		public void AddButton(Button b)
		{
			for (int i = 0; i < buttons.Count; i++)
			{
				Controls.Add(b);
				b.Location = new Point(150, 10 + i * 20);
				b.Click += B_Click;
			}
		}

		private void B_Click(object sender, EventArgs e)
		{
			foreach(Button b in AbButtons)
			{
				b.Enabled = false;
			}
			IndChosen = buttons.IndexOf(sender as Button);
			textBox1.Text = Animals[IndChosen].Talk();
			if (Animals[buttons.IndexOf(sender as Button)] is IFly)
			{
				AbButtons[0].Enabled = true;
			}
			if (Animals[IndChosen] is ISwim)
			{
				AbButtons[1].Enabled = true;
			}
			if (Animals[IndChosen] is IRun)
			{
				AbButtons[2].Enabled = true;
			}
			AbButtons[3].Enabled = true;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text = (Animals[IndChosen] as IFly).Fly();
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text = (Animals[IndChosen] as ISwim).Swim();
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text = (Animals[IndChosen] as IRun).Run();
		}
		private void button10_Click(object sender, EventArgs e)
		{
			textBox1.Text = Animals[IndChosen].Talk();
		}
	}
}
