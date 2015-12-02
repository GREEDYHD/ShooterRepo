using UnityEngine;
using System.Collections;

public class Tile
{
	public enum TileType
	{
		TT_EMPTY,
		TT_FLOOR,
		TT_WALL
	}

	World mWorld;
	TileType mTileType = TileType.TT_FLOOR;

	public TileType Type {
		get {
			return mTileType;
		}
	}

	int  mPositionX;
	int mPositionY;
	SpriteRenderer mSpriteRenderer;

	public Tile (World world, int x, int y)
	{
		mWorld = world;
		mPositionX = x;
		mPositionY = y;
	}
}