using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionHolderController : MonoBehaviour {
    public GameObject redPotion;
    public GameObject bluePotion;
    public GameObject greenPotion;

    public Color sleeveColor = Color.yellow;

    private void Start() {
        //GameObject.Find("red_fluid").GetComponent<Renderer>().material.color = sleeveColor;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            if (redPotion.activeSelf == false) {
                redPotion.SetActive(true);
            } else if (redPotion.activeSelf == true && Input.GetKeyDown(KeyCode.Alpha2) && Input.GetKeyDown(KeyCode.Alpha3)){
                redPotion.SetActive(false);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            if (bluePotion.activeSelf == false) {
                bluePotion.SetActive(true);
            }
            else if (bluePotion.activeSelf == true && Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha3)) {
                bluePotion.SetActive(false);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            if (greenPotion.activeSelf == false) {
                greenPotion.SetActive(true);
            }
            else if (greenPotion.activeSelf == true && Input.GetKeyDown(KeyCode.Alpha1) && Input.GetKeyDown(KeyCode.Alpha2)) {
                greenPotion.SetActive(false);
            }
        }
        
    }
}
