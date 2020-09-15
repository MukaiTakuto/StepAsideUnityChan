using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScript : MonoBehaviour
{

    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    GameObject MainCamera;



    // Start is called before the first frame update
    void Start()
    {
        MainCamera = GameObject.Find("Main Camera");
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.z < MainCamera.transform.position.z)
        {
            Destroy(gameObject);
        }
        
    }
}
