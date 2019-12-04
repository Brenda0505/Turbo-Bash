using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Som : MonoBehaviour
{
    //Play Global
    private static Som instance = null;
    public static Som Instance
    {
        get { return instance; }
    }
    void Awake()
    {

        if (instance != null && instance != this)

        {
            Destroy(this.gameObject);
            return;
        }

        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

    }

    //Play Global End  


}
