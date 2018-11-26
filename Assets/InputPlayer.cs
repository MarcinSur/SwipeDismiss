using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InputPlayer : MonoBehaviour 
{
    //IClickedObject clickedObject= new MouseInput();
    public GameObject selectedObject;
    public GameObject prevoisObject;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            selectedObject = gameObject.GetGameObject();
            if(selectedObject!= null)
            {
                selectedObject.GetComponent<TileController>().Check();
            }
        }
    }

}
public interface IClickedObject
{
    GameObject GetGameObject();
}

public static class ExtensionMethods 
{
    /// <summary>
    /// return clicked gameobject using RaycastHit2D and ScreenToWorldPoint (working only with 2D gameobjects
    /// </summary>
    /// <param name="gameObject"></param>
    /// <returns></returns>
    public static GameObject GetGameObject(this GameObject gameObject)
    {
        Physics2D.queriesStartInColliders = true;

        GameObject go;
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 zero = new Vector2(0, 0);
        RaycastHit2D hit = Physics2D.Raycast(mousePos, zero);
        if (hit.collider != null)
        {
            Debug.Log("CLICK object name = " + hit.collider.name);
            go = hit.collider.gameObject;
        }
        else
        {
            go = null;
        }
        return go;
    }
}