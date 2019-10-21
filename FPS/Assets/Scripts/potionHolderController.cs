using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potionHolderController : MonoBehaviour {
    public GameObject redPotion;
    public GameObject bluePotion;
    public GameObject greenPotion;
    public Material sleeveMaterial;

    public int potionsDrunk;
    public bool isFading;
    public bool canDrink = true;

    public float fadeStart;
    public float fadeTime = 1.5f;
    public Color32 startColor;
    public Color32 resultColor;
    public float counter;
    public float maxCounter = 1;

    public Color32 sleeveColor;
    public byte redness = 0;
    public byte blueness = 0;
    public byte greenness = 0;

    private void Start() {
        sleeveColor = new Color32(redness, greenness, blueness, 255);
    }

    private void Update() {

        sleeveMaterial.color = sleeveColor;
        startColor = sleeveColor;

        if (Input.GetKeyDown(KeyCode.Alpha1)) {
            if (redPotion.activeSelf == false) {
                redPotion.SetActive(true);
                bluePotion.SetActive(false);
                greenPotion.SetActive(false);
            }
            else if (redPotion.activeSelf == true) {
                redPotion.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {
            if (bluePotion.activeSelf == false) {
                bluePotion.SetActive(true);
                redPotion.SetActive(false);
                greenPotion.SetActive(false);
            }
            else if (bluePotion.activeSelf == true) {
                bluePotion.SetActive(false);
            }
        }

        if (Input.GetKeyDown(KeyCode.Alpha3)) {
            if (greenPotion.activeSelf == false) {
                greenPotion.SetActive(true);
                redPotion.SetActive(false);
                bluePotion.SetActive(false);
            }
            else if (greenPotion.activeSelf == true) {
                greenPotion.SetActive(false);
            }
        }

        //DRINKING
        if (Input.GetKeyDown(KeyCode.Mouse0) && isFading == false) {
            if (redPotion.activeSelf == true) {
                redness += 85;
                potionsDrunk += 1;
                sleeveColor = new Color32(redness, greenness, blueness, 255);
                resultColor = sleeveColor;
                isFading = true;
            }
            if (bluePotion.activeSelf == true) {
                blueness += 85;
                potionsDrunk += 1;
                sleeveColor = new Color32(redness, greenness, blueness, 255);
                resultColor = sleeveColor;
                isFading = true;
            }
            if (greenPotion.activeSelf == true) {
                greenness += 85;
                potionsDrunk += 1;
                sleeveColor = new Color32(redness, greenness, blueness, 255);
                resultColor = sleeveColor;
                isFading = true;
            }
        }        

        //FADING
        if (isFading) {
            if (counter > maxCounter) {
                if (fadeStart < fadeTime) {
                    fadeStart += Time.deltaTime / fadeTime;
                    sleeveColor = Color.Lerp(startColor, resultColor, fadeStart);
                }
                else {
                    fadeStart = 0;
                    counter = 0;
                    isFading = false;
                }
            }
            else {
                counter += Time.deltaTime / maxCounter;
                sleeveColor = startColor;
            }
        }

        //BARFING
        if (potionsDrunk == 3) {
            potionsDrunk = 0;
        }
    }
}
