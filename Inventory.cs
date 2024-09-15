using System.Collections.Generic;

public abstract class Inventory<T> where T : IEnumerable<Item> {
	public T items { get; set; }
	public Inventory(T items) {
		this.items = items;
	}
}
