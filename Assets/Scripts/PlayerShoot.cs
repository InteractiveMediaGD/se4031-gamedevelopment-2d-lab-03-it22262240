using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    public CameraShake camShake;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            if(camShake != null) 
            {
                StartCoroutine(camShake.Shake(0.15f, 0.2f));
            } // This bracket was missing!
        }
    }
}