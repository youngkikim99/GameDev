using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadAssets : MonoBehaviour
{
    public GameObject redObj;
    [SerializeField]
    private GameObject blueObj;
    public Vector3 redVector = new Vector3(2f, 0f, 0f);
    public Vector3 blueVector = new Vector3(-2f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(redObj, redVector, Quaternion.identity);
        Instantiate(blueObj, blueVector, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
