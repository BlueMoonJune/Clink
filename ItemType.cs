
using Microsoft.Xna.Framework.Graphics;
using Clink;

public abstract class ItemType {

	public abstract string TexturePath {get;}

	public static readonly ItemType instance;
	public Texture2D texture;

	public ItemType() {
		texture = Main.instance.Content.Load<Texture2D>(TexturePath);
	}
}

public class DirtItem : ItemType {
	public override string TexturePath => "Tiles/Dirt"; // TODO use correct path
}
