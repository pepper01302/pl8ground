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
            this.isValid = GameManager.allowedObjects.Contains(toClone.name);
        }
    }
    /// <summary>
    /// Spawns an object.
    /// </summary>
    /// <param name = "obj">The GameObject to spawn.</param>
    /// <param name = "position">The position to spawn the Object.</param>
    /// <param name = "rotation">The rotation to spawn the Object with.</param>
    /// <param name = "inWorldSpace">Whether or not the Object is spawned in world space.</param>
    /// <returns>The object created, null if not.</returns>
    public static Object Spawn(GameObject obj, Vector3 position, Quaternion rotation, bool inWorldSpace = false) {
        Object created = new Object(obj);
        if (created.isValid) {
            created.gameObject = UnityEngine.Object.Instantiate(obj);
            created.gameObject.name = obj.name;
            if (inWorldSpace) {
                created.gameObject.transform.position = position;
                created.gameObject.transform.rotation = rotation;
            } else {
                created.gameObject.transform.localPosition = position;
                created.gameObject.transform.localRotation = rotation;
            }
        }
        return created.isValid ? created : null;
    }
}