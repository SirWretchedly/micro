using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highlight : MonoBehaviour
{
    public Sprite highlighted, notHighlighted;

    private void OnMouseEnter()
    {
        try
        {
            transform.GetComponent<SpriteRenderer>().sprite = highlighted;
        }
        catch
        {
            transform.GetComponent<Image>().sprite = highlighted;
        }
    }

    private void OnMouseExit()
    {
        try
        {
            transform.GetComponent<SpriteRenderer>().sprite = notHighlighted;
        }
        catch
        {
            transform.GetComponent<Image>().sprite = notHighlighted;
        }
    }
}
