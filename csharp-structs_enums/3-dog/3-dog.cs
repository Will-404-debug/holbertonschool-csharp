using System;

public struct Dog
{
	public string name;   // Dog's name
	public float age;     // Dog's age
	public string owner;  // Dog's owner
	public Rating rating; // Dog's rating

	// Constructor with parameters
	public Dog(string name, float age, string owner, Rating rating)
	{
		this.name = name;
		this.age = age;
		this.owner = owner;
		this.rating = rating;
	}

	// Override ToString method
	public override string ToString()
	{
		return $"Dog Name: {name}\nAge: {age}\nOwner: {owner}\nRating: {rating}";
	}
}

public enum Rating
{
	Good,       // 0
	Great,      // 1
	Excellent   // 2
}
