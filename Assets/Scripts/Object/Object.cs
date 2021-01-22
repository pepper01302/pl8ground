using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object {
    // Documentation :sleeping:
    /// <summary>
    /// Whether or not the Object is valid.
    /// </summary>
    public bool isValid { get; private set; }
    /// <summary>
    /// The GameObject of the object. This is what you spawn with Object.Spawn().
    /// </summary>
    public GameObject gameObject { get; private set; }

    /// <summary>
    /// Creates a new object, by cloning from a GameObject.
    /// </summary>
    /// <param name = "toClone">The GameObject to clone.</param>
    public Object(GameObject toClone) {
        if (!GameManager.debugMode) {
            // TODO: Check if it's valid.
        }
    }
    /// <summary>
    /// Spawns an object
    /// </summary>
    /// <param name = "obj">The GameObject to spawn.</param>
    /// <returns>The object created, null if not.</returns>
    public static Object Spawn(GameObject obj) {
        // TODO: Spawn the object after checking if it's valid.
        Object created = new Object(obj);
        return created.isValid ? created : null;
    }
}