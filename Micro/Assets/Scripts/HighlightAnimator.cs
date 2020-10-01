using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightAnimator : MonoBehaviour
{
    private void OnMouseEnter()
    {
        transform.GetComponent<Animator>().SetBool("highlighted", true);
    }

    private void OnMouseExit()
    {
        transform.GetComponent<Animator>().SetBool("highlighted", false);
    }
}
