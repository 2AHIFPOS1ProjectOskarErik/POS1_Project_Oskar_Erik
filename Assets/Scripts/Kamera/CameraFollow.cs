using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Hilfe von: https://www.youtube.com/watch?v=8rnRvotQmdg&t=5s
    public Transform player;
    
    Vector3 vel = Vector3.zero;
    [SerializeField] Vector3 offset;
    [SerializeField] float damping;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetpos = player.position + offset;
        targetpos.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, targetpos, ref vel, damping);
    }
}
