using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dynamic_light : MonoBehaviour
{
    public GameObject directionalLightObject;
    public float light_cycle = 10;
    private Light directionalLight;
    public float current_time;
    // Start is called before the first frame update
    void Start()
    {
        directionalLight = directionalLightObject.GetComponent<Light>();
        current_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        return;
        float timePercent = 1 - (Time.time % light_cycle) / light_cycle;
        float intensity_scale = (Mathf.Cos(2*Mathf.PI*timePercent)+1)/2;
        directionalLight.color = Color.white * intensity_scale;
    }
}
