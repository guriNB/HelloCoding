using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloCode : MonoBehaviour
{
    void Start()
    {
        float distance = GetDistance(2, 2, 5, 6);
        Debug.Log("(2, 2)에서 (5, 6)까지의 거리 : " + distance);
    }

    float GetDistance(float x1, float y1, float x2, float y2)
	{
        float width = x2 - x1;
        float hight = y2 - y1;

        float distance = width * width + hight * hight;
        distance = Mathf.Sqrt(distance);

        return distance;
	}
}
