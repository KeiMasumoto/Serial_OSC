using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SerialSend : MonoBehaviour
{
    //SerialHandler.cのクラス
    public SerialHandler serialHandler;
    int i = 0;
    int direction = 0;
    
    void FixedUpdate() //ここは0.001秒ごとに実行される
    {
        i = i + 1;   //iを加算していって1秒ごとに"1"のシリアル送信を実行

        // インプットを取得し1ならば"1"
        if (Input.GetKey (KeyCode.Alpha1)) {
            direction = 1;
        }
        else if(Input.GetKey (KeyCode.Alpha2)) {
            direction = 2;
        }
        else if(Input.GetKey (KeyCode.Alpha3)) {
            direction = 3;
        }
        else if(Input.GetKey (KeyCode.Alpha4)) {
            direction = 4;
        }

        
        if (i > 999 && direction == 1) //
        {
            serialHandler.Write("1");
            i = 0;
        }
        else if (i > 999 && direction == 2) //
        {
            serialHandler.Write("2");
            i = 0;
        }
        else if (i > 999 && direction == 3) //
        {
            serialHandler.Write("3");
            i = 0;
        }
        else if (i > 999 && direction == 4) //
        {
            serialHandler.Write("4");
            i = 0;
        }
    }
}
