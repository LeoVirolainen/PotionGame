using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drink : MonoBehaviour {

    public Animator anim;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Mouse1)) {
            anim.Play("drink");
        }
      //  if (Input.GetKeyUp(KeyCode.Mouse1)) {
   //         anim.SetBool("drink", false);
   //     }
        if (Input.GetKeyDown(KeyCode.Mouse0)) {
            anim.Play("attack");
        }
   //     if (Input.GetKeyUp(KeyCode.Mouse0)) {
   //         anim.SetBool("attack", false);
   //     }
    }
}
