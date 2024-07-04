using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positonHandler : MonoBehaviour
{
    private Vector3 position;

    public void SetPositionY (float value )
    {
        position = transform.position;
        position.y = value * 15;
        transform.position = position;
    }


}
