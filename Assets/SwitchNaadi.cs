using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchNaadi : MonoBehaviour {

    public GameObject[] Naadis;

    public void switchNaadi(int n)
    {
        foreach (GameObject x in Naadis)
            x.SetActive(false);
        Naadis[n].SetActive(true);
    }
}
