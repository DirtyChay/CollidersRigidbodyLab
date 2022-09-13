using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour {
    /*
     * Rigid body mass is higher than player (1 vs 100), so will automatically move player
     * on impact. All that's left is to delete this.
     */
    void OnCollisionEnter2D(Collision2D coll) {
        GameObject other = coll.gameObject;
        if (isPlayer(other)) {
            Destroy(gameObject);
        }
    }

    bool isPlayer(GameObject obj) {
        return obj.CompareTag("Player");
    }
}