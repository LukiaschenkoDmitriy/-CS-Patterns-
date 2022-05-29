namespace CommandPattern {
	abstract class TransferControl {
		public abstract void TransferingControll();
	}

	abstract class Command: TransferControl {
		protected string _name {get; set;}
		public abstract void Connect();
		public abstract void Disconnect();

		public override void TransferingControll() {}

		public string GetName() => _name;
	}

	class Keyboard: Command {
		public Keyboard() => _name = "Keyboard";

		private void GetKeyboardControll() => Console.WriteLine("Controll transferred Keyboard");
		public override void TransferingControll() => GetKeyboardControll();

		public override void Connect() => Console.WriteLine("KeyBoard connected!");
		public override void Disconnect() => Console.WriteLine("KeyBoard disconnected!");
	}

	class Joystick: Command {
		public Joystick() => _name = "Joystick";

		private void GetJoyskickControll() => Console.WriteLine("Controll transferred Joystick");
		public override void TransferingControll() => GetJoyskickControll();

		public override void Connect() => Console.WriteLine("Joystick connected!");
		public override void Disconnect() => Console.WriteLine("Joystick disconnected!");
	}

	class VR: Command {
		public VR() => _name = "VR";

		private void GetVRControll() => Console.WriteLine("Controll transferred VR");
		public override void TransferingControll() => GetVRControll();

		public override void Connect() => Console.WriteLine("VR connected!");
		public override void Disconnect() => Console.WriteLine("VR disconnected!");
	}

	class EmptySlot: Command {
		public EmptySlot() => _name = "Empty slot";

		private void GetEmptySlotControll() {}
		public override void TransferingControll() => GetEmptySlotControll();

		public override void Connect() {}
		public override void Disconnect() {}
	}

	class Controller {
		private Command[] _devices;

		public Controller(int slots) {
			_devices = new Command[slots+1];
			for(int i=0; i<slots+1; i++) {
				_devices[i] = new EmptySlot();
			}
		}

		private void CheckOnMaxIndex(int index) {
			if (_devices.Length < index) {throw new Exception($"Controller have {_devices.Length-1} slots");}
		}

		public void AddDeviceInSlot(int slot, Command device) {
			CheckOnMaxIndex(slot);
			if (!(_devices[slot] is EmptySlot)) {throw new Exception("Slot busy!");}
			_devices[slot] = device;
			ConnectDevice(slot);
		}

		public void ClearDeviceInSlot(int slot) {
			CheckOnMaxIndex(slot);
			DisconnectDevice(slot);
			_devices[slot] = new EmptySlot();
		}

		public void GetDeviceControll(int slot){
			CheckOnMaxIndex(slot);
			_devices[slot].TransferingControll();

		}

		private void ConnectDevice(int slot) => _devices[slot].Connect();
		private void DisconnectDevice(int slot) => _devices[slot].Disconnect();

		public void GetInfo() {
			Console.WriteLine($"Controller have {_devices.Length-1} slots");
			for(int i=0; i < _devices.Length-1; i++) {
				Console.WriteLine($"Slot {i+1}: {_devices[i].GetName()}");
			}
		}
	}
}