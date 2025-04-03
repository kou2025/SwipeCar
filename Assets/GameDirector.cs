using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    //Findは処理重いので、publicにしてGameDirectorにアタッチすればいい
    //GameObject型でなく、Transform型にできる。※これができない時もある
    //Transformだけは、Getcompornentで取得する必要はない。（良く使われるから）
    public Transform car;
    public Transform flag;
    public TextMeshProUGUI distance;
    //GameObject flag;
    //GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //-1.62fは微調整。オブジェクトの中点が違う為
        float length = this.flag.position.x -
            this.car.position.x-1.62f;
        this.distance.text = 
            "距離:" + length.ToString("F2") + "m";
    }
}
