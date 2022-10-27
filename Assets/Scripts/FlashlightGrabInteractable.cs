using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FlashlightGrabInteractable : XRGrabInteractable
{
    [SerializeField]
    private GameObject spotlight;

    [SerializeField]
    private MeshRenderer flashlightGlass;

    [SerializeField]
    private Material glassMaterial, flashMaterial;

    private bool isOn = false;

    protected override void OnActivated(ActivateEventArgs args)
    {
        base.OnActivated(args);

        if (isOn)
        {
            // We need to turn off
            flashlightGlass.material = glassMaterial;
            spotlight.SetActive(false);
            isOn = false;
        }
        else
        {
            // We need to turn on
            flashlightGlass.material = flashMaterial;
            spotlight.SetActive(true);
            isOn = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
