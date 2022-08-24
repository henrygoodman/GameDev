using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public Renderer rend;
    int i = 3;
    int rand;
    // Start is called before the first frame update
    void Start()
    {
        rand = Random.Range(200, 250);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
        if (gameObject.tag.Equals("Red") && i == 100)
        {
            gameObject.SetActive(false);
        }
        else
        {
            gameObject.SetActive(true);
        }
        if (gameObject.tag.Equals("Blue") && i == rand)
        {
            rend.enabled = false;
        } 
        else
        {
            rend.enabled = true;
        }
    }
}
