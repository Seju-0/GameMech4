using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGun : MonoBehaviour
{
    public LayerMask groundLayer; // Define the ground layer in the Unity editor and assign it here
    public GameObject portalPrefab; // Drag and drop your portal prefab in the inspector
    public Transform shootingPoint; // Assign the shooting point GameObject in the inspector

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Left mouse button
        {
            FirePortal();
        }
    }

    void FirePortal()
    {
        RaycastHit hit;
        if (Physics.Raycast(shootingPoint.position, shootingPoint.forward, out hit, Mathf.Infinity, groundLayer))
        {
            CreatePortal(hit.point);
        }
    }

    void CreatePortal(Vector3 position)
    {
        Instantiate(portalPrefab, position, Quaternion.identity);
    }
}
