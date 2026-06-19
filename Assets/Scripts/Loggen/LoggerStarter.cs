using UnityEngine;

public class LoggerStarter : MonoBehaviour
{
    void Awake()
    {
        FileLogger.Init();
    }
}