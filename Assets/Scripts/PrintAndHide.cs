using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public GameObject gameObj;
    public int i = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObj.name + ":" + i);
        if (i == 100 && gameObj.CompareTag("Red"))
        {
            gameObj.SetActive(false);
        }
        if (i == Random.Range(200, 251) && gameObj.CompareTag("Blue"))
        {
            rend.enabled = false;
        }
    }
}
