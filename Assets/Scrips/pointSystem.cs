using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointSystem : MonoBehaviour
{

    private int count;
    public Text countText;

    void Start()
    {
        count = 0;
        setCountText();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("point"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            print(count);
            setCountText();
        }
    }

    void setCountText()
    {
        countText.text = "Count: " + count.ToString ();
    }

}
