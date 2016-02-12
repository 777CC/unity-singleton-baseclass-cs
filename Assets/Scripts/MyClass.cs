using UnityEngine;
using System.Collections;

public class MyClass : MonoBehaviour
{
    void Awake()
    {
        Debug.Log(Manager.Instance.myGlobalVar);
    }
}