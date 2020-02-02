using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drink : MonoBehaviour {

    public Animator anim;
    public bool altAtk = false;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            anim.Play("drink");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && (altAtk == false)) {
            anim.Play("attack0");
            altAtk = true;
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0) && (altAtk == true)) {
            anim.Play("attack1");
            altAtk = false;
        }
    }
}
