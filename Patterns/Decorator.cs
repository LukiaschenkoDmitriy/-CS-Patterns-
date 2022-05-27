namespace DecoratorPattern
{
	abstract class Computer
	{
		private int _price = 0;
		private string _descruption = "";

		public virtual int GetPrice() => this._price;
		public virtual string GetDescruption() => this._descruption;
	}

	abstract class ComputerDecorator : Computer
	{
		protected Computer _computerDecorator;

		protected string name;
		protected int price;

		public override int GetPrice() => _computerDecorator.GetPrice() + price;
		public override string GetDescruption() => _computerDecorator.GetDescruption() + ", " + name;
	}

	abstract class MotherBoard : ComputerDecorator { }
	abstract class VideoCard : ComputerDecorator { }
	abstract class Mouse : ComputerDecorator { }
	abstract class KeyBoard : ComputerDecorator { }

	class GemdirdKeyBoard : KeyBoard
	{
		public GemdirdKeyBoard(Computer _computer)
		{
			_computerDecorator = _computer;
			(name, price) = ("Keyboard: Gembird", 10);

		}
	}

	class IntelMotherBoard : MotherBoard
	{
		public IntelMotherBoard(Computer _computer)
		{
			_computerDecorator = _computer;
			(name, price) = ("Mother Board: Any Intel", 100);
		}
	}

	class NvidiaVideoCard : VideoCard
	{
		public NvidiaVideoCard(Computer _computer)
		{
			_computerDecorator = _computer;
			(name, price) = ("Video Card: Any NVidia", 150);
		}
	}

	class RealtekMouse : Mouse
	{
		public RealtekMouse(Computer _computer)
		{
			_computerDecorator = _computer;
			(name, price) = ("Mouse: Any Realtek mouse", 20);
		}
	}

	class UltraMegaComputer : Computer
	{
		public override int GetPrice() => 1000;
		public override string GetDescruption() => "UltraMegaComputer";
	}
}

