using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class ExplodeWhenHit : MonoBehaviour
{
    public GameObject TargetExplosion;
    public GameObject Targetvis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            print("Collision detected");
            TargetExplosion.SetActive(true);
            Targetvis.SetActive(false);

            Destroy(collision.gameObject); // Destroy bullet
            Invoke("DestroyTargetContainer", 2.5f); // Call function DestroyTargetContainer
        }
        
    }

    public void DestroyTargetContainer()
    {
        Destroy(transform.parent.gameObject);
        ApplicationData.MakeNewBullet = true;
        ApplicationData.MakeNewTarget = true;
    }
}
