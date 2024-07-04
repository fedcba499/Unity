using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scope : MonoBehaviour
{
    public Camera mainCamera;    
    public float scopedFOV = 15f;
    public float normalFOV = 60f;
    public Image scopeOverlay;
    public KeyCode scopeKey = KeyCode.Mouse1;

    private bool isScoped = false;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(scopeKey))
        {
            ToggleScope();
        }
        
    }

    void ToggleScope()
    {
        isScoped = !isScoped;
        scopeOverlay.enabled = isScoped;

        if(isScoped)
        {
            mainCamera.fieldOfView = scopedFOV;
        }
        else
        {
            mainCamera.fieldOfView = normalFOV;
        }
        
    }
}
