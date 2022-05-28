namespace Singleton {
	class Human {
		private static Human? instanceHuman;
		private string life;

		public string name;
		public byte age;

		private Human(string name) {
			this.name = name;
			age = 0;
			life = "A simple child who was skeptical of people." + 
				   "But this did not affect his future interest in programming,"+
				   "and the study of man as a person.";
		}

		public static Human? GetInstance(string name) {
			if (instanceHuman == null) {instanceHuman = new Human(name);}
			return instanceHuman;
		}

		public void AddYear() => age++;
	}
}