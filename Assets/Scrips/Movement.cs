using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class Movement : MonoBehaviour
{
    float posX;
    float posY;
    float posZ;
    float moveby = 30;
    bool moved = false;
    // Start is called before the first frame update
    void Start()
    {
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;
        StartCoroutine(basicMovement());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator basicMovement()
    {
        while (true)
        {

            yield return new WaitForSeconds(3f);

            transform.DOMove(new Vector3(posX + 30, posY, posZ), 2);

            yield return new WaitForSeconds(3f);

            transform.DOMove(new Vector3(posX, posY, posZ), 2);
 
        }

    }
}
