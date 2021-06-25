using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objective : MonoBehaviour
{

    public GameObject objective;
    private float xPos;
    private float zPos;
    private int Objcount;

    private void Start()
    {
        OBJDrop();
    }

    void OBJDrop()
    {
        while (Objcount < 1)
        {
            xPos = Random.Range(-0.3f, 37);
            zPos = Random.Range(-0.3f, 37);
            Instantiate(objective, new Vector3(xPos, 0.2f, zPos), Quaternion.identity);
            Objcount += 1;
        }
    }
  
}