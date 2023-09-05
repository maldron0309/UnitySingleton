using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        DataManager.Instance.Save();
        GameManager.Instance.Game();
        
    }
}
