using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{

    private float slowMo = .2f;
    private float normTime = 1f;

    public Vector2 touchpad;
    public float speed = 2f;
    public GameObject ovr;

    public AudioSource audi;

    public float time;
    public float timebtw = 1f;

    public float dr = 10f;


    public GameObject cameraCenter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles = new Vector3(0, cameraCenter.transform.localEulerAngles.y, 0);

        touchpad = OVRInput.Get(OVRInput.Axis2D.PrimaryTouchpad);

        transform.Translate(Vector3.forward * speed * touchpad.y * Time.deltaTime);
        transform.Translate(Vector3.right * speed * touchpad.x * Time.deltaTime);

        Vector3 position = new Vector3(transform.position.x, transform.position.y + 0.5f, transform.position.z);
        ovr.transform.position = Vector3.Lerp(ovr.transform.position, position, 10f * Time.deltaTime);
    }
}
