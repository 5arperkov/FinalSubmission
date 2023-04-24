using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Vector3 characterStartPosition = new Vector3 (0, 0, -3);
    public float moveSpeed = 3;
    // public float rotationSpeed = 1;
    public float horizontal;
    public float vertical;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = characterStartPosition;
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 movementDirection = new Vector3(horizontal, 0, vertical);
        movementDirection.Normalize();

        transform.Translate(movementDirection * moveSpeed * Time.deltaTime, Space.World);

        if (movementDirection != Vector3.zero)
        {
            anim.SetFloat("characterSpeed", 1);

            // float angle = Mathf.Atan2(horizontal, Mathf.Abs(vertical)) * Mathf.Rad2Deg;
            // transform.Rotate(0.0f, angle*Time.deltaTime, 0.0f, Space.Self);
            /*
            Quaternion toRotation = Quaternion.LookRotation(movementDirection, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotationSpeed * Time.deltaTime);
            */
        }
        else 
        {
            anim.SetFloat("characterSpeed", 0);
        }
    }
}
