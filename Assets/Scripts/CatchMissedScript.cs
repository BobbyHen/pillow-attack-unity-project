using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class CatchMissedScript : MonoBehaviour
{
    public AudioSource MissedSound;
    public Transform MissImpactPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision MyBulletCollision)
    {
        if (MyBulletCollision.gameObject.tag == "bullet")
        {
            Destroy(MyBulletCollision.gameObject);

            ContactPoint contact = MyBulletCollision.contacts[0];

            Vector3 pos = contact.point;
            //Quaternion.identity is the rotation of this object, the wall. so the hole will be perfectly "stuck" to the wall, like a poster
            Instantiate(MissImpactPrefab, pos, Quaternion.identity);

            // Randomize pitch of sound
            MissedSound.pitch = UnityEngine.Random.Range(0.4f, 1.6f);
            MissedSound.Play();

            // Tell Game Manager to create new bullet
            ApplicationData.MakeNewBullet = true;

        }
    }
}
