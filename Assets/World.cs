using UnityEngine;
using System.Collections;

public class World
{
	string mName;
	Tile[,] mTiles;
	int mWidth;

	public int Width {
		get {
			return mWidth;
		}
		set {
			mWidth = value;
		}
	}

	int mHeight;

	public int Height {
		get {
			return mHeight;
		}
		set {
			mHeight = value;
		}
	}

	public World (int w = 100, int h = 100)
	{
		mWidth = w;
		mHeight = h;
		mTiles = new Tile[mWidth, mHeight];

		for (int i = 0; i < mWidth; i++) {
			for (int j = 0; j < mHeight; j++) {
				mTiles [i, j] = new Tile (this, i, j);
			}
		}
		Debug.Log ("World Created");
	}

	public Tile FetchTileAt (int x, int y)
	{
		if (x >= 0 && x <= mWidth && y >= 0 && y <= mHeight) {
			return mTiles [x, y];
		}
		return null;
	}
}