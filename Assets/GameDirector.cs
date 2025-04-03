using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameDirector : MonoBehaviour
{
    GameObject car;
    GameObject flag;
    GameObject distance;
    // Start is called before the first frame update
    void Start()
    {
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
    }

    // Update is called once per frame
    void Update()
    {
        //-1.62fは微調整。オブジェクトの中点が違う為
        float length = this.flag.transform.position.x -
            this.car.transform.position.x-1.62f;
        this.distance.GetComponent<TextMeshProUGUI>().text = 
            "Distance:" + length.ToString("F2") + "m";
    }
}
