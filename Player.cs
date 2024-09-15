using Microsoft.Xna.Framework;
using System.Collections.Generic;

public class Player {
	public Vector3 pos { get; set; }
	public Vector3 velocity { get; set; }
	public PlayerInventory inventory { get; set; }
	
	public Player(Vector3 pos) {
		this.pos = pos;
	}
}

public class PlayerInventory : Inventory<List<Item>> {
	public PlayerInventory(List<Item> items) : base(items) {}
}
