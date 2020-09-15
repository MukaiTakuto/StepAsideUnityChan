using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject carPrefab;
    public GameObject coinPrefab;
    public GameObject conePrefab;
    private GameObject unitychan;
    private float difference;

    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 360;

    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;

    bool isCalledOnce = false;
    bool isCalledOnce2 = false;
    bool isCalledOnce3 = false;
    bool isCalledOnce4 = false;
    bool isCalledOnce5 = false;
    bool isCalledOnce6 = false;
    bool isCalledOnce7 = false;
    bool isCalledOnce8 = false;
    bool isCalledOnce9 = false;
    bool isCalledOnce10 = false;
    bool isCalledOnce11 = false;
    bool isCalledOnce12 = false;
    bool isCalledOnce13 = false;
    bool isCalledOnce14 = false;
    bool isCalledOnce15 = false;
    bool isCalledOnce16 = false;
    bool isCalledOnce17 = false;
    bool isCalledOnce18 = false;







       
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    
    void Update()
    {
        this.unitychan = GameObject.Find("unitychan");
        if(unitychan.transform.position.z > 40)
        {
            if (!isCalledOnce) {
                isCalledOnce = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
                    
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
        
        // }

            }
        }
        if(unitychan.transform.position.z > 55)
        {
                if (!isCalledOnce2) {
                isCalledOnce2 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=15;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
         if(unitychan.transform.position.z > 70)
        {
                if (!isCalledOnce3) {
                isCalledOnce3 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=30;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 85)
        {
                if (!isCalledOnce4) {
                isCalledOnce4 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=45;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    
    if(unitychan.transform.position.z > 100)
        {
                if (!isCalledOnce5) {
                isCalledOnce5 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=60;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    if(unitychan.transform.position.z > 115)
        {
                if (!isCalledOnce6) {
                isCalledOnce6 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=75;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    if(unitychan.transform.position.z > 130)
        {
                if (!isCalledOnce7) {
                isCalledOnce7 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=90;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 145)
        {
                if (!isCalledOnce8) {
                isCalledOnce8 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=105;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    
    if(unitychan.transform.position.z > 160)
        {
                if (!isCalledOnce9) {
                isCalledOnce9 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=120;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    if(unitychan.transform.position.z > 175)
        {
                if (!isCalledOnce10) {
                isCalledOnce10 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=135;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    if(unitychan.transform.position.z > 190)
        {
                if (!isCalledOnce11) {
                isCalledOnce11 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=150;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 205)
        {
                if (!isCalledOnce12) {
                isCalledOnce12 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=165;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 220)
        {
                if (!isCalledOnce13) {
                isCalledOnce13 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=180;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 235)
        {
                if (!isCalledOnce14) {
                isCalledOnce14 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=195;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 250)
        {
                if (!isCalledOnce15) {
                isCalledOnce15 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=210;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 265)
        {
                if (!isCalledOnce16) {
                isCalledOnce16 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=225;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 280)
        {
                if (!isCalledOnce17) {
                isCalledOnce17 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=240;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
        if(unitychan.transform.position.z > 295)
        {
                if (!isCalledOnce18) {
                isCalledOnce18 = true;
     
        //一定の距離ごとにアイテムを生成
        // for(int i = startPos; i < goalPos; i +=15)
        // {
            int i = startPos;
            i +=255;
        
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                 //コーンをx軸方向に一直線に生成
                 for(float j = -1; j <= 1; j += 0.4f)
                 {
                     GameObject cone = Instantiate(conePrefab);
                     cone.transform.position = new Vector3(4 * j, cone.transform.position.y, i);
                 }
            }
            else
            {
                 //コーンをx軸方向に一直線に生成
                for(int j = -1; j <= 1; j++)
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
                        coin.transform.position = new Vector3 (posRange * j, coin.transform.position.y, i + offsetZ);
                    }
                    else if(7 <= item && item <= 9)
                    {
                        //車を生成
                        GameObject car = Instantiate(carPrefab);
                        car.transform.position = new Vector3 (posRange * j, car.transform.position.y, i + offsetZ);
                    
                    }
                }

            }
            
        
        // }

            }
            
        }
    }
    
    
}
