using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Askingabout : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1, Vector2.up);
        transform.rotation *= rotationY;
    }


}
