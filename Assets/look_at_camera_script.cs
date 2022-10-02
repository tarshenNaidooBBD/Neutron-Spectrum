using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look_at_camera_script : MonoBehaviour
{

    public Vector3 i_p = new Vector3(-10, 30, 116);//initial position
    public Vector3 o_p = new Vector3(350, 6, 80); //offset position

    // Start is called before the first frame update
    void Start()
    {
        Vector3 n_p = new Vector3(i_p.x + Random.Range(0, o_p.x),i_p.y + Random.Range(0, o_p.y),i_p.z + Random.Range(0, o_p.z)); //offset position
        transform.position = n_p;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt( GameObject.FindWithTag("Player").transform);
    }
}
