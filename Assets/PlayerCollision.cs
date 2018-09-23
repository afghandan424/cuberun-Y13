using UnityEngine;

public class PlayerCollision : MonoBehaviour {
    void OnCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Debug.Log(collisionInfo.gameObject.tag);
    }
}
