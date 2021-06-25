using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.UI;

public class SlowMotionMov : MonoBehaviour
{

    public Vector2 touchpad;
    private float slowMo = 0.1f;
    private float normTime = 1.0f;
    private bool doSlowMo = false;

    [SerializeField]
    private FirstPersonController player;

    private void Update()
    {
    touchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);
        if (touchpad.y == 0 && touchpad.x == 0)
        {
            if (doSlowMo)
            {
                Time.timeScale = normTime;
                Time.fixedDeltaTime = 0.2f * Time.timeScale;
                doSlowMo = false;
            }
        }
        else
        {
            if (!doSlowMo)
            {
                Time.timeScale = slowMo;
                Time.fixedDeltaTime = 0.002f * Time.timeScale * Time.deltaTime;
                doSlowMo = true;
            }
        }
    }
}
