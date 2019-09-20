using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if PLATFORM_ANDROID
using UnityEngine.Android;
#endif

public class cameraperm : MonoBehaviour
{
    // Start is called before the first frame update
    private void Awake()
    {
        Permission.RequestUserPermission(Permission.Camera);
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
