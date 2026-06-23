using UnityEngine;
using System.IO;

public class FileLogger
{
    // ChatGPT code Anfang
    static public string filePath;
    static private bool initiated = false;
    public static void Init()
    {
        Application.logMessageReceived += HandleLog;
        string logDirectory = Path.GetFullPath(Path.Combine(Application.dataPath, "../Logs"));
        if (!Directory.Exists(logDirectory))
        {
            Directory.CreateDirectory(logDirectory);
        }
        filePath = Path.Combine(logDirectory, "Crystal_Knight_LOG.txt");
        File.WriteAllText(filePath,"");
        initiated = true;
        Debug.Log("[i] Logger initialized");
    }

    private static void HandleLog(string logString, string stackTrace, LogType type)
    {
        
        File.AppendAllText(
            filePath,
            $"[{System.DateTime.Now:HH:mm:ss}] [{type}] {logString}\n"
        );
        
    }
    // ChatGPT code Ende
}
