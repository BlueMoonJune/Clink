using Microsoft.Xna.Framework.Graphics;
using Clink;

public abstract class TileType {

	public abstract string TexturePath {get;}

	public static readonly TileType instance;
	public Texture2D texture;

	public TileType() {
		texture = Main.instance.Content.Load<Texture2D>(TexturePath);
	}
}

public class DirtTile : TileType {
	public override string TexturePath => "Tiles/Dirt";
}
