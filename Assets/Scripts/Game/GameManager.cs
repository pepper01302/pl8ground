using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {
    /// <summary>
    /// The list of allowed GameObjects to turn into Objects.
    /// </summary>
    public static List<GameObject> allowedObjects { get; private set; }
    /// <summary>
    /// Whether or not the game is in Debug Mode (bypass restrictions).
    /// </summary>
    // TODO: Change this to false.
    public static bool debugMode { get; private set; } = true;
    private void Start() {
        // TODO: Read from a file and set the allowedObjects list.
    }
}
