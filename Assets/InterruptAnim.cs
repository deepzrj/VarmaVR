using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterruptAnim : MonoBehaviour {

	public void IntrAnim()
    {
        var tempAnim = GetComponent<Animator>();
        tempAnim.SetBool("interrupt", true);
    }
}
