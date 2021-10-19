using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBearMat : MonoBehaviour
{
    System.Random random = new System.Random();
     
     // Set the materials in the inspector
     public Material[] bearColors = new Material[5];
 
     // Use this for initialization
     void Start ()
     {
         // Assigns a random material at start
         gameObject.GetComponent<Renderer>().material = bearColors[random.Next(0, bearColors.Length)];
     }

    // Update is called once per frame
    void Update()
    {
        
    }

    
}
