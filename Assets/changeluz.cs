using System.Collections;
using UnityEngine;
using UnityEngine.Rendering.Universal;



public class ChangeLight : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float minDistance = 5f;
    [SerializeField] private Light2D lightSource; 
    [SerializeField] private float duration = 45.0f;
    [SerializeField] private float targetIntensity = 0.15f;
    private float initialIntensity;
    private bool isDimming = false; 

    void Start()
    {
        if (lightSource == null)
        {
            lightSource = GetComponent<Light2D>(); 
        }
        initialIntensity = lightSource.intensity; 
    }

    void Update()
    {
        float sqrDistance = (player.transform.position - transform.position).sqrMagnitude;
        float sqrMinDistance = minDistance * minDistance;

        if (sqrDistance < sqrMinDistance && !isDimming)
        {
            StartCoroutine(DecreaseLightIntensity());
        }
    }

    private IEnumerator DecreaseLightIntensity()
    {
        isDimming = true;
        float elapsedTime = 0f;

        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            lightSource.intensity = Mathf.Lerp(initialIntensity, targetIntensity, elapsedTime / duration);
            yield return null;
        }

        lightSource.intensity = targetIntensity;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, minDistance);
    }
}
