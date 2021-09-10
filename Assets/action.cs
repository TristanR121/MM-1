using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class action : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            transform.Rotate(new Vector3(0, 0, 90)); // rotate the player

            if (transform.rotation.eulerAngles.z < 91 && transform.rotation.eulerAngles.z > 89) // see if player is rotated green block down
            {
                gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic; // changing the rigidbody type
                gameObject.GetComponent<Move>().enabled = false; // turning off move script
            }
            else
            {
                gameObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Kinematic; // changing the rigidbody type
                gameObject.GetComponent<Move>().enabled = true; // turning on move script

            }
        }
    }
}
