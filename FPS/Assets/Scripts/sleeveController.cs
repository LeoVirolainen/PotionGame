using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sleeveController : MonoBehaviour
{

    Renderer rend;

    private void Start() {
        rend = GetComponent<Renderer>();
    }

    private void Update() {
        rend.material.color = GameObject.Find("PotionHolder").GetComponent<potionHolderController>().sleeveColor;
    }
}
