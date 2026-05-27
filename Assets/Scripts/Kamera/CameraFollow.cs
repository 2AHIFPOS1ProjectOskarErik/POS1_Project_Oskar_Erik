using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    // Hilfe von: https://www.youtube.com/watch?v=8rnRvotQmdg&t=5s
    public Transform player;
    public static CameraFollow instance;
    Vector3 vel = Vector3.zero;
    [SerializeField] public Vector3 offset;
    [SerializeField] float damping;
    public GameObject camera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        DontDestroyOnLoad(camera);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetpos = player.position + offset;
        targetpos.z = transform.position.z;
        transform.position = Vector3.SmoothDamp(transform.position, targetpos, ref vel, damping);
    }
}
