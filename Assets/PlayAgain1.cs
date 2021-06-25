using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgain1 : MonoBehaviour
{
    private void Start()
    {
    }

    float timeLeft = 8f;


    void Awake()
    {

    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene(1);
        }

    }
}
