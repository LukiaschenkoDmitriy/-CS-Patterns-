namespace ObserverPattern {
	abstract class ReactorComponent {
		bool status = false;
		protected string? nameComponent;

		protected int minLoad {get; set;}
		protected int maxLoad {get; set;}

		public void UpdateStatusComponents(int load) {
			if (load > maxLoad && status) {
				status = false;
				NotifyMessage(load);
			}
			else if (load < minLoad && !status) {
				status = true;
				NotifyMessage(load);
			}
		}

		protected void NotifyMessage(int load) {
			if (status) {
				Console.WriteLine($"\n{nameComponent} run");
				Console.WriteLine($"Load Reactor: {load}%");
				return;
			}
			Console.WriteLine($"\n{nameComponent} stopped work");
			Console.WriteLine($"Load Reactor: {load}%");
		}
	}

	class FirstEnergoBlock:ReactorComponent {
		public FirstEnergoBlock() {
			nameComponent = "First Energo Block";
			minLoad = 50;
			maxLoad = 70;
		}
	}

	class SecondEnergoBlock:ReactorComponent {
		public SecondEnergoBlock() {
			nameComponent = "Second Energo Block";
			minLoad = 60;
			maxLoad = 80;
		}
	}

	class ThreeEnergoBlock:ReactorComponent {
		public ThreeEnergoBlock() {
			nameComponent = "Three Energo Block";
			minLoad = 70;
			maxLoad = 90;
		}
	}

	abstract class SystemObserver {
		protected List<ReactorComponent> components = new List<ReactorComponent>();

		public void AddComponent(ReactorComponent component) {
			if (!components.Contains(component)) {components.Add(component);}
		}

		public void RemoveComponent(ReactorComponent component) {
			if (components.Contains(component)) {components.Remove(component);}
		}
	}

	class EnergoSystem: SystemObserver {
		private int reactorLoad = 0;

		public void ReactorLoad(int load) {
			reactorLoad = load;
			UpdateAllStatusComponents();
		}

		private void UpdateAllStatusComponents() {
			foreach(ReactorComponent component in components) {
				component.UpdateStatusComponents(reactorLoad);
			}
		}
	}
}