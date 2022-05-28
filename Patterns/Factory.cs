namespace FactoryPatterns {
	abstract class Ship {
		protected string _nameShip;

		protected int _health;
		protected int _shild;
		protected Weapon _weapon;

		protected abstract Weapon InstallWeapon(string weaponName);
		public void SetWeapon(string weaponName) {
			_weapon = InstallWeapon(weaponName);
		}

		public void GetInfo() {
			Console.WriteLine(_nameShip);
			Console.WriteLine($"Health: {_health}");
			Console.WriteLine($"Shild: {_shild}");
			Console.WriteLine($"Gun: {_weapon.GetInfo()}");
		}
	}

	class DefaultShip:Ship {
		public DefaultShip(string weaponName) {
			_nameShip = "Default Ship";
			_health = 100;
			_shild = 100;
			_weapon = InstallWeapon(weaponName);
		}

		protected override Weapon InstallWeapon(string weaponName) {
			if (weaponName.Equals("default")) {
				return new Machinegun();
			}
			else if (weaponName.Equals("laser")) {
				return new Laser();
			}
			else if (weaponName.Equals("rocket")) {
				return new Rocket();
			}
			else {
				throw new Exception("Not fount gun");
			}
		}
	}

	class SuperShip:Ship {
		public SuperShip(string weaponName) {
			_nameShip = "Super Ship";
			_health = 200;
			_shild = 200;
			_weapon = InstallWeapon(weaponName);
		}

		protected override Weapon InstallWeapon(string weaponName) {
			if (weaponName.Equals("default")) {
				return new SuperMachinegun();
			}
			else if (weaponName.Equals("laser")) {
				return new SuperLaser();
			}
			else if (weaponName.Equals("rocket")){
				return  new SuperRocket();
			}
			else {
				throw new Exception("Not fount gun");
			}
		}
	}
}