using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameraController : MonoBehaviour
{
    
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    // public GameObject carPrefab;
    // public GameObject coinPrefab;
    // public GameObject conePrefab;


    //Unityちゃんとカメラの距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        // this.carPrefab = GameObject.Find("carPrefab");

        
        
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z-difference);
        
    }
}
