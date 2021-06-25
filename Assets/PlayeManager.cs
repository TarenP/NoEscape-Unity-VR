using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayeManager : MonoBehaviour
{
    #region Singleton

    public static PlayeManager instance;

    private void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;
}
