using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class GameManager : MonoBehaviour {
    /// <summary>
    /// The list of the names of allowed GameObjects to turn into Objects.
    /// </summary>
    public static List<string> allowedObjects { get; private set; } = new List<string>();
    /// <summary>
    /// Whether or not the game is in Debug Mode (bypass restrictions).
    /// </summary>
    public static bool debugMode { get; private set; } = false;
    private void Start() {
        string dir = Path.Combine(Application.persistentDataPath, "hub");
        string path = Path.Combine(Application.persistentDataPath, "hub", "whitelistobjects.txt");
        if (!Directory.Exists(dir)) {
            Directory.CreateDirectory(dir);
        }
        if (!File.Exists(path)) {
            Debug.Log("Creating whitelist file");
            // For some reason, we have to create the file and then close it.
            FileStream f = File.Create(path);
            f.Close();
            Debug.Log("Whitelist file complete! Writing all GameObjects...");
            #region Objects array
            // THERE IS NO OTHER WAY TO DO THIS
            // TODO: Try and find a better way to do this.
            string[] toWrite = {
                "bowling_ball"
            };
            #endregion
            File.WriteAllLines(path, toWrite);
        }
        string[] objects = File.ReadAllLines(path);
        foreach (string obj in objects) {
            allowedObjects.Add(obj);
        }

        Object.Spawn(GameObject.Find("bowling_ball"), new Vector3(0, 0), Quaternion.Euler(new Vector3(0, 0)));
    }
}
