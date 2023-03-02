using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartParticleSys : MonoBehaviour {
    public ParticleSystem[] Array,VarmaPoints;
	
    public void startMainEmmision()
    {
        foreach (ParticleSystem i in Array)
            i.Play();
    }

    public void StartEmmision(int x)
    {
        VarmaPoints[x].Play();
        SphereCollider i = VarmaPoints[x].gameObject.GetComponent<SphereCollider>();
        i.enabled = true; 
    }

    public void StartEmmisionArray(int a)
    {
        for(int i=0;i<=a;i++)
        {
            if(!VarmaPoints[i].isPlaying)
            VarmaPoints[i].Play();
            SphereCollider x = VarmaPoints[i].gameObject.GetComponent<SphereCollider>();
            x.enabled = true;
        }

    }
}
