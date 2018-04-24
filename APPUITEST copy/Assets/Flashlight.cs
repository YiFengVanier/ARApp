using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

public class Flashlight : MonoBehaviour {
    public Toggle toggle;

        void Turnon(bool toggle) {
        
        if (toggle == true)
        {
            CameraDevice.Instance.SetFlashTorchMode(true);
        }
        if (toggle != true)
        {
            CameraDevice.Instance.SetFlashTorchMode(false);
        }
    }
}
