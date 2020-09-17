using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private GameObject unitychan;
    private GameObject Instan;

    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;

    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;

    // bool isCalledOnce = false;
    // bool isCalledOnce2 = false;
    // bool isCalledOnce3 = false;
    // bool isCalledOnce4 = false;
    // bool isCalledOnce5 = false;
    // bool isCalledOnce6 = false;
    // bool isCalledOnce7 = false;
    // bool isCalledOnce8 = false;
    // bool isCalledOnce9 = false;
    // bool isCalledOnce10 = false;
    // bool isCalledOnce11 = false;
    // bool isCalledOnce12 = false;
    // bool isCalledOnce13 = false;
    // bool isCalledOnce14 = false;
    // bool isCalledOnce15 = false;
    // bool isCalledOnce16 = false;
    // bool isCalledOnce17 = false;
    // bool isCalledOnce18 = false;
        float z = 15f;







       
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");
        if(z < 320)
        {
    
        if(unitychan.transform.position.z > z)
        {
        //一定の距離ごとにアイテムを生成
                                   
                        //どのアイテムを出すのかをランダムに設定
                        int num = Random.Range (1, 11);
                        if (num <= 2)
                        {
                                //コーンをx軸方向に一直線に生成
                                for (float j = -1; j <= 1; j += 0.4f)
                                {
                                        GameObject cone = Instantiate (conePrefab);
                                        cone.transform.position = new Vector3 (4 * j, cone.transform.position.y, z+40);
                                }
                        }
                        else
                        {

                                //レーンごとにアイテムを生成
                                for (int j = -1; j <= 1; j++)
                                {
                                        //アイテムの種類を決める
                                        int item = Random.Range (1, 11);
                                        //アイテムを置くZ座標のオフセットをランダムに設定
                                        int offsetZ = Random.Range(-5, 6);
                                        //60%コイン配置:30%車配置:10%何もなし
                                        if (1 <= item && item <= 6)
                                        {
                                                //コインを生成
                                                GameObject coin = Instantiate (coinPrefab);
                                                coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, z +40 + offsetZ);
                                        }
                                        else if (7 <= item && item <= 9)
                                        {
                                                //車を生成
                                                GameObject car = Instantiate (carPrefab);
                                                car.transform.position = new Vector3 (posRange * j, car.transform.position.y, z+ 40 + offsetZ);
                                        }
                                }
                        }
                
	    z = z + 15f;
        
        }
        }
        
    }

}
