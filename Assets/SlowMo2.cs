using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowMo2 : MonoBehaviour
{
    public bool isslowmo = false;

    float currentAmount = 0f;
    float maxAmount = 1f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.PrimaryIndexTrigger))
        {
            isslowmo = !isslowmo;
        }

        if (isslowmo)
        {
                Time.timeScale = 0.003f;
            Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }
        else
        {
                Time.timeScale = 1.1f;
                Time.fixedDeltaTime = 0.02f * Time.timeScale;
        }



        if (!isslowmo)

                currentAmount += Time.deltaTime;
                if (currentAmount > maxAmount)
                {

                    currentAmount = 0f;
                    Time.timeScale = 1.0f;
                }
    }
        

        
}

