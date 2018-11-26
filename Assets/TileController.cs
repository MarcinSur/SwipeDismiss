using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileController : MonoBehaviour
{

    public TileData tile;
    public Vector2[] directions = { Vector2.up, Vector2.down, Vector2.right, Vector2.left };

    public void Check()
    {
        if (!gameObject.activeSelf)
            return;
        ClearMatch(new Vector2[2] { Vector2.left, Vector2.right });
        ClearMatch(new Vector2[2] { Vector2.up, Vector2.down });
    }

    public GameObject GetNeighbour(Vector2 castDir)
    {
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, castDir);
        if (hit.collider != null)
        {
            Debug.DrawRay(transform.position, castDir, Color.white);
            Debug.Log(hit.collider.gameObject.name);
            return hit.collider.gameObject;
        }
        return null;
    }

    public List<GameObject> GetAllNeighbours()
    {
        List<GameObject> neighbours = new List<GameObject>();
        for (int i = 0; i < directions.Length; i++)
        {
            neighbours.Add(GetNeighbour(directions[i]));
        }
        return neighbours;
    }

    public List<GameObject> FindMatch(Vector2 castDir)
    {
        List<GameObject> matchingTiles = new List<GameObject>();
        Debug.Log("FindMatch in vector = " + castDir);
        Physics2D.queriesStartInColliders = false;
        RaycastHit2D hit = Physics2D.Raycast(transform.position, castDir);
        while (hit.collider != null && hit.collider.GetComponent<TileController>().tile.tileType == tile.tileType)
        {
            matchingTiles.Add(hit.collider.gameObject);
            hit = Physics2D.Raycast(hit.collider.transform.position, castDir);
        }
        return matchingTiles;
    }

    public void ClearMatch(Vector2[] paths)
    {
        List<GameObject> matchingTilese = new List<GameObject>();
        for (int i = 0; i < paths.Length; i++)
        {
            matchingTilese.AddRange(FindMatch(paths[i]));
        }
        if (matchingTilese.Count >= 2)
        {
            for (int i = 0; i < matchingTilese.Count; i++)
            {
                matchingTilese[i].SetActive(false);
                gameObject.SetActive(false);
            }
        }
    }
}
