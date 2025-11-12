using UnityEngine;

public class TaxiIdleShake : MonoBehaviour
{
    public float shakeSpeed = 10f;      // how fast it vibrates
    public float shakeAmount = 0.4f;    // how strong the shake feels

    private Quaternion startRot;

    void Start()
    {
        startRot = transform.localRotation;
    }

    void Update()
    {
        // smooth subtle engine idle effect
        float t = Time.time * shakeSpeed;
        float rotX = Mathf.Sin(t) * shakeAmount;
        float rotZ = Mathf.Cos(t * 1.2f) * shakeAmount;

        transform.localRotation = startRot * Quaternion.Euler(rotX, 0, rotZ);
    }
}
