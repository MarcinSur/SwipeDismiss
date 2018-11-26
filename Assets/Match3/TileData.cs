using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TileData {

    public TileType tileType;
    public int positionInBoard;
    public int row;
    public int column;
    public SpriteRenderer spriteRenderer;
    public bool isEmpty;
    public bool hasPair;
}
[SerializeField]
public enum TileType
{
    WHITE,
    RED,
    BLUE,
    GREEN,
    YELLOW,
    BLACK,
    PURPLE,
    NONE,
    EMPTY
}
