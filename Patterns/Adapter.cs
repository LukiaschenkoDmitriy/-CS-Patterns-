namespace AdapterPattern {
	abstract class Energy {
		protected int _energy;

		public Energy(int _energy) => this._energy = _energy;

		public int GetEnergy() => _energy;
	}

	class V24:Energy {
		public V24():base(24) {}
	}

	class V48:Energy{
		public V48():base(48) {}
	}

	class V96:Energy {
		public V96():base(96) {}
	}

	abstract class Resistor {
		protected Energy _energy;
		protected int _maximumEnergy;

		public int GetEnergy() {
			int energyValue = this._energy.GetEnergy();
			if (energyValue >= _maximumEnergy) {return _maximumEnergy;}
			return energyValue;
		}

		public void GetResistorInfo() {
			Console.WriteLine($"Maximum charge that the resistor can handle: {_maximumEnergy}");
		}
	}

	class Resistor24V:Resistor {
		public Resistor24V(Energy _energy) {
			this._energy = _energy;
			_maximumEnergy = 24;
		}
	}

	class Resistor48V:Resistor {
		public Resistor48V(Energy _energy) {
			this._energy = _energy;
			_maximumEnergy = 48;
		}
	}

	class Resistor96V:Resistor {
		public Resistor96V(Energy _energy) {
			this._energy = _energy;
			_maximumEnergy = 96;
		}
	}
}