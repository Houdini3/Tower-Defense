using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathwayLogic : MonoBehaviour
{
    public static Vector3[] Waypoints;
    private void Awake()
    {
        int childerenCount = transform.childCount;
        Waypoints = new Vector3[childerenCount];

        for (int i = 0; i < childerenCount; i++)
        {
            Waypoints[i] = transform.GetChild(i).position;
        }
    }
}
