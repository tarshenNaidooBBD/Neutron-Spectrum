using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astro_movement : MonoBehaviour
{
    public CharacterController controller;

    public float max_speed = 6f;
    public float speed = 0f;
    public float gravity = -9.8f;
    public float jump_force = 20f;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, gravity/max_speed, vertical).normalized;
        if (direction.x != 0 || direction.z != 0) {
            Vector3 look_direction = new Vector3(direction.x, 0f, direction.z);
            transform.rotation = Quaternion.LookRotation(look_direction);
        }
        controller.Move(direction * max_speed * Time.deltaTime);
    }

    void Jump()
    {

    }
}
