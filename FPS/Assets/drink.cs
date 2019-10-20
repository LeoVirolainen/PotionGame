using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drink : MonoBehaviour {

    public Animator anim;

    void Update() {
        if (Input.GetKey(KeyCode.Mouse0)) {
            anim.SetBool("drink", true);
        }
        if (Input.GetKeyUp(KeyCode.Mouse0)) {
            anim.SetBool("drink", false);
        }
    }
}
