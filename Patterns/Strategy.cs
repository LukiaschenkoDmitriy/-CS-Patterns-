namespace StrategyPattern {
	abstract class EmitAdapter {
		public abstract void Emit();
	}

	abstract class Animal: EmitAdapter {
		protected string _animal {get; set;}
		public abstract void Eat();
		public abstract void Move();
		public override void Emit() {}

		public string GetAnimalName() => _animal;
	}

	abstract class Dog: Animal {
		public override void Eat() => Console.WriteLine($"{_animal} is eating like a dog");
		public override void Move() => Console.WriteLine($"{_animal} is moving like a dog");
		protected abstract void Bark();

		public override void Emit() => Bark();
	}

	abstract class Snake: Animal {
		public override void Eat() => Console.WriteLine($"{_animal} is eating like a snake");
		public override void Move() => Console.WriteLine($"{_animal} is moving like a snake");
		protected abstract void Hiss();

		public override void Emit() => Hiss();
	}

	abstract class Cat: Animal {
		public override void Eat() => Console.WriteLine($"{_animal} is eating like a cat");
		public override void Move() => Console.WriteLine($"{_animal} is moving like a cat");
		protected abstract void Meow();

		public override void Emit() => Meow();
	}

	class Bulldog: Dog {
		public Bulldog() => _animal = "Bulldog";
		protected override void Bark() => Console.WriteLine("woof, woof");
	}

	class Lablador: Dog {
		public Lablador() => _animal = "Lablador";
		protected override void Bark() => Console.WriteLine("Woof!, Woof!");
	}

	class Persian: Cat {
		public Persian() => _animal = "Persian";
		protected override void Meow() => Console.WriteLine("Meow!!, Meow!!!");
	}

	class British: Cat {
		public British() => _animal = "British Coon";
		protected override void Meow() => Console.WriteLine("meow,meow");
	}

	class Aniliidae: Snake {
		public Aniliidae() => _animal = "Aniliidae";
		protected override void Hiss() => Console.WriteLine("Hssssss!!!");
	}

	class Bolyeriidae : Snake {
		public Bolyeriidae () => _animal = "Bolyeriidae ";
		protected override void Hiss() => Console.WriteLine("Hss..");
	}

	class TheBestAnimal {
		Animal _animal = new Lablador();

		public void ChangeAnimal(Animal _animal) {
			this._animal = _animal;
		}

		public void TestingAnimal() {
			Console.WriteLine($"Animal: {this._animal.GetAnimalName()}");
			this._animal.Move();
			this._animal.Eat();
			this._animal.Emit();
		}
	}
}