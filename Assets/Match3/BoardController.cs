using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class BoardController : MonoBehaviour {

    public BoardSettings boardSettings;
    public Vector2 boardOffset;
    public List<GameObject> allTiles = new List<GameObject>();
    public List<TileData> tiles;

    // Use this for initialization
    void Start () {
        for (int row = 0; row < boardSettings.row; row++)
        {
            for (int column = 0; column < boardSettings.column; column++)
            {
                GameObject go = Instantiate(boardSettings.tilePrefabs);
                TileData tile = go.GetComponent<TileController>().tile;
                go.transform.DOLocalMoveX(boardOffset.x + column,0);
                go.transform.DOLocalMoveY(boardOffset.y - row, 0);
                tiles.Add(tile);
                allTiles.Add(go);
                tile.positionInBoard = tiles.Count;
                go.name = "Tile " + row + "_"+ column;
                tile.tileType = RandomTileType();
                tile.spriteRenderer.color = GetColorByType(tile.tileType);
                tile.row = row;
                tile.column = column;
            }
        }
    }

    private Color GetColorByType(TileType tt)
    {
        Color color = new Color();
        switch (tt)
        {
            case TileType.WHITE:
                color = Color.white;
                break;
            case TileType.RED:
                color = Color.red;
                break;
            case TileType.BLUE:
                color = Color.blue;
                break;
            case TileType.GREEN:
                color = Color.green;
                break;
            case TileType.YELLOW:
                color = Color.yellow;
                break;
            case TileType.BLACK:
                color = Color.black;
                break;
            case TileType.PURPLE:
                color = Color.cyan;
                break;
            default:
                break;
        }
        return color;
    }

    private TileType RandomTileType()
    {
        TileType tt = (TileType)Random.Range(0, 6);
        return tt;
    }
}
