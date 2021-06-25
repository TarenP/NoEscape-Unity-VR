using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gAMEoVER : MonoBehaviour
{

    public int numScenes = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            if(Time.time > 5)
            {
                Debug.Log("Killed");
                GameOver();
            }
            else
            {
                Destroy(other.gameObject);
            }

        }
    }

    void GameOver()
    {
        SceneManager.LoadScene(Random.Range(2, numScenes + 2));
    }
}
