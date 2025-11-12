using UnityEngine;

public class CloudMoveScript : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        // ✅ Move left in WORLD space (fixed)
        transform.Translate(new Vector3(-0.5f, 0, 0) * Time.deltaTime, Space.World);
    }
}
