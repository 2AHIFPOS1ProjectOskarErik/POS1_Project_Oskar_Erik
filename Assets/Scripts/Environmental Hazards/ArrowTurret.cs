using UnityEngine;

public class ArrowTurret : MonoBehaviour
{
    public GameObject arrowPrefab;

    void Start()
    {
        InvokeRepeating("Shoot", 1f, 2f);
    }

    void Shoot()
    {
        Instantiate(
            arrowPrefab,
            transform.position,
            transform.rotation
        );
    }
}