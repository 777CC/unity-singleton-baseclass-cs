using UnityEngine;
using System.Collections;

public class Manager : Singleton<Manager>
{
    protected Manager() { } // guarantee this will be always a singleton only - can't use the constructor!

    public string myGlobalVar = "whatever";
}