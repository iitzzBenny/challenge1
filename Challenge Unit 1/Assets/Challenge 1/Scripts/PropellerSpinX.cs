using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    private float _anglesPerSecond = 120;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is the Bonus part of the challenge. I found this code on a Forum (https://forum.unity.com/threads/how-to-rotate-only-the-zaxis-of-object.829554/)
        Vector3 rotation = transform.localEulerAngles;
        rotation.z += Time.deltaTime * _anglesPerSecond;
        transform.localEulerAngles = rotation;
        
    }
}
