using UnityEngine;

public class WaterMoveScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // ✅ Move right in WORLD space (fixed)
        transform.Translate(new Vector3(0.5f, 0, 0) * Time.deltaTime, Space.World);
    }
}
