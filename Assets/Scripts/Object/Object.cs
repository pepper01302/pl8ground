using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object {
    // Documentation :sleeping:
    /// <summary>
    /// Whether or not the Object is valid
    /// </summary>
    public bool isValid { get; private set; }

    /// <summary>
    /// Creates a new object, by cloning from a GameObject
    /// </summary>
    /// <param name = "toClone">The GameObject to clone</param>
    public Object(GameObject toClone) {
        
    }
    /// <summary>
    /// Spawns an object
    /// </summary>
    /// <param name = "obj">The GameObject to spawn</param>
    /// <returns>The object created, null if not</returns>
    public static Object Spawn(GameObject obj) {
        return new Object(obj);
    }
}