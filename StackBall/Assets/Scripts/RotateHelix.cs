using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHelix : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        if (PlayerCtrl.Instance.isGameActive == true)
        {
            transform.Rotate(0, Time.deltaTime * 30f, 0);
        }
            
    }
}
