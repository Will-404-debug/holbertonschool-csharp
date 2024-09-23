using System;

namespace Enemies
{
	/// <summary>
	/// Represents a zombie enemy.
	/// </summary>
	public class Zombie
	{
		/// <summary>
		/// The health of the zombie (private).
		/// </summary>
		private int health;

		/// <summary>
		/// The name of the zombie (private). Defaults to "(No name)".
		/// </summary>
		private string name = "(No name)";

		/// <summary>
		/// Gets or sets the name of the zombie.
		/// </summary>
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		/// <summary>
		/// Initializes a new instance of the Zombie class with health set to 0.
		/// </summary>
		public Zombie()
		{
			health = 0;
		}

		/// <summary>
		/// Initializes a new instance of the Zombie class with a specified health value.
		/// </summary>
		/// <param name="value">The health value to set.</param>
		/// <exception cref="ArgumentException">Thrown when value is less than 0.</exception>
		public Zombie(int value)
		{
			if (value < 0)
			{
				throw new ArgumentException("Health must be greater than or equal to 0");
			}
			health = value;
		}

		/// <summary>
		/// Returns the health of the zombie.
		/// </summary>
		/// <returns>The health value of the zombie.</returns>
		public int GetHealth()
		{
			return health;
		}
	}
}
