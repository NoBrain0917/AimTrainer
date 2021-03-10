using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBounds : MonoBehaviour
{

    public static TargetBounds Instance;

    void Awake() {
        Instance = this;
    }

    [SerializeField] BoxCollider collider;

    public Vector3 GetRandomPosition(){
        Vector3 center = collider.center + transform.position;
        float minX = center.x - collider.size.x / 2f;
        float maxX = center.x + collider.size.x / 2f;

        float minY = center.y - collider.size.y / 2f;
        float maxY = center.y + collider.size.y / 2f;

        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector3 randomPosition = new Vector3(randomX, randomY, 9);
        return randomPosition;
    }

    // Start is called before the first frame update

}
