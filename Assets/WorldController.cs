using UnityEngine;
using System.Collections;

public class WorldController : MonoBehaviour
{
	public Sprite mFloorSprite;

	void Start ()
	{
		World tWorld = new World ();


		for (int i = 0; i < tWorld.Width; i++) {
			for (int j = 0; j < tWorld.Height; j++) {
				GameObject tTileGameObject = new GameObject ();
				tTileGameObject.name = "TILE_[" + i + " , " + j + "]";
				tTileGameObject.transform.position = new Vector2 (i, j);
				tTileGameObject.transform.parent = transform;
				SpriteRenderer tSpriteRenderer = tTileGameObject.AddComponent<SpriteRenderer> ();

				Tile tTile = tWorld.FetchTileAt (i, j);

				if (tTile.Type == Tile.TileType.TT_FLOOR) {
					tSpriteRenderer.sprite = mFloorSprite;
				}
			}
		}
	}
}
