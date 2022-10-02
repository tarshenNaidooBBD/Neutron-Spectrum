using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shimmerControl : MonoBehaviour
{
    public GameObject pointLightObject;
    public float light_cycle;
    public float light_intensity;
    private Light pointLight;
    // Start is called before the first frame update
    void Start()
    {
        pointLight = pointLightObject.GetComponent<Light>();
        light_cycle = Random.Range(2f, 6f);
        //light_intensity = Random.Range(0.5f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        float timePercent = 1 - (Time.time % light_cycle) / light_cycle;
        float intensity_scale = (Mathf.Cos(2*Mathf.PI*timePercent)+1)/2;
        pointLight.intensity = intensity_scale * light_intensity;
    }
}
