using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryLoad : SceneLoad
{
    public void LoadRetry()
    {
        LoadScene();
        GameManager.instance.GameReset();
    }
}
