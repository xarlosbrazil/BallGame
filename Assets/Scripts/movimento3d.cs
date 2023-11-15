using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class MousePointerMovement : MonoBehaviour
{
    [SerializeField] private float speed;

    private Camera mainCamera;
    private Rigidbody rb;
    Collider planeCollider;
    RaycastHit hit;
    Ray ray;

    private void Start()
    {
        mainCamera = Camera.main;
        planeCollider = GameObject.Find("UCX_Cube").GetComponent<Collider>();
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        // transform.position = mainCamera.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2));
        // transform.position = Vector3.SmoothDamp(transform.position, hit.point, ref speed, smoothTime);
        ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit) && Input.GetMouseButton(0))

        {
            if (hit.collider == planeCollider)

            {

                Vector3 forca = hit.point - transform.position;
                forca.Normalize();

                rb.AddForce(forca * speed);
            }
        }

    }
}
