using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollission : MonoBehaviour
{
    public GameObject exp;

     void OnCollisionEnter(Collision collision)
    {
       if(collision.gameObject.name == "bandit")
        {
            //Destroy(gameObject);
          gameObject.SetActive(false);

            if(collision.gameObject.name == "bandit") {
                collision.gameObject.SetActive(false);
                exp.SetActive(true);
                
            }
           // Destroy(collision.gameObject);
            
        }

        if (collision.gameObject.tag == "enemy")
        {
            //Destroy(gameObject);
            gameObject.SetActive(false);

            if (collision.gameObject.tag == "enemy")
            {
                collision.gameObject.SetActive(false);
                exp.SetActive(true);

            }
            // Destroy(collision.gameObject);

        }

        Destroy(gameObject, 1);
    }

}
