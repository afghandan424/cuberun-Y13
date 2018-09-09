
using UnityEngine;

public class Collision : MonoBehaviour {
    
    void onCollisionEnter(UnityEngine.Collision collisionInfo)
    {
        Debug.Log(collisionInfo.gameObject.tag);

    }

}
