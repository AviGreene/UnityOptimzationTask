using UnityEngine;

public class ArrowObject : MonoBehaviour
{
    public float speed;
    public float damage;
    public float selfDestructionTime;
    
    void Start()
    {
        Destroy(gameObject, selfDestructionTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * ( speed * Time.deltaTime));
    }
}
