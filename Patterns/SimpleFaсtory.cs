namespace FactoryPatterns {
	//Not Pattern
	abstract class Weapon {
		protected int _damage = 0;
		public int GetDamageValue() => _damage;
		public abstract string GetInfo();
	}

	class Laser: Weapon {
		public Laser() => _damage = 1000;
		public override string GetInfo() => "Laser";
	}

	class SuperLaser: Weapon {
		public SuperLaser() => _damage = 3000;
		public override string GetInfo() => "Super Laser";
	}

	class Machinegun: Weapon {
		public Machinegun() => _damage = 100;
		public override string GetInfo() => "Machinegun";
	}

	class SuperMachinegun: Weapon {
		public SuperMachinegun() => _damage = 300;
		public override string GetInfo() => "Super Machinegun";
	}

	class Rocket: Weapon {
		public Rocket() => _damage = 600;
		public override string GetInfo() => "Rocket";
	}

	class SuperRocket: Weapon {
		public SuperRocket() => _damage = 2000;
		public override string GetInfo() => "SuperRocket";
	}

	class SimpleShip {
		private Weapon _weapon {get; set;}
		public SimpleShip(string weaponName) {
			InstallWeapon(weaponName);
		}

		private void InstallWeapon(string weaponName) {
			if (weaponName.Equals("Laser")) {
				_weapon = new Laser();
			}
			else if (weaponName.Equals("Machinegun")) {
				_weapon = new Machinegun();
			}
			else if (weaponName.Equals("Rocket")) {
				_weapon = new Rocket();
			}
		}
	}
}