using UnityEngine;
using System.Collections; // You MUST have this for IEnumerator to work

public class CameraShake : MonoBehaviour
{
    public IEnumerator Shake(float duration, float magnitude)
    {
        // Capture the position relative to its starting point
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0f;

        while (elapsed < duration)
        {
            // Calculate a random offset
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            // Apply the offset TO the original position
            transform.localPosition = new Vector3(originalPos.x + x, originalPos.y + y, originalPos.z);

            elapsed += Time.deltaTime;

            // Wait for the next frame
            yield return null;
        }

        // Reset precisely to the original position
        transform.localPosition = originalPos;
    }
}