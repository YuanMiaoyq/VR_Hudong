using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeTexture : MonoBehaviour
{
    public Material[] material; 
    private void Update()
    {
        float time = 0; 
       
            for (int i = 0; i < material.Length; )
            {
                time += Time.deltaTime;
            if (time > 0.6)
            {
                GameObject go = GameObject.Find("moviexlz");
                go.GetComponent<MeshRenderer>().material = material[i];
                time = 0;
                i++;
            }  
        } 
    }
}
