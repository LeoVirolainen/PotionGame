using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordRotator : MonoBehaviour {

    public GameObject fPC;
    public GameObject fPSController;

    void Start() {

    }

    void Update() {
        transform.rotation = Quaternion.Euler(fPC.transform.localEulerAngles.x, fPSController.transform.localEulerAngles.y, 0);
    }
}
