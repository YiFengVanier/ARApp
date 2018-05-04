using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class position : MonoBehaviour
{
    public TextMesh Status_Text;

    // Use this for initialization
    void Start()
    {
        Input.compass.enabled = true;
        Input.location.Start();
    }

    // Update is called once per frame
    void Update()
    {
        var xrot = Mathf.Atan2(Input.acceleration.z, Input.acceleration.y);
        var yzmag = Mathf.Sqrt(Mathf.Pow(Input.acceleration.y, 2) + Mathf.Pow(Input.acceleration.z, 2));
        var zrot = Mathf.Atan2(Input.acceleration.x, yzmag);

        var xangle = xrot * (180 / Mathf.PI) + 90;
        var zangle = -zrot * (180 / Mathf.PI);
        transform.eulerAngles = new Vector3((xangle - (xangle%1)), 0, ((zangle - Input.compass.trueHeading) - ((zangle - Input.compass.trueHeading)%1)));
       
            if (Status_Text != null)
        {
            Status_Text.text = (Input.compass.trueHeading - ((Input.compass.trueHeading)%1)).ToString();
        }
    }
}
