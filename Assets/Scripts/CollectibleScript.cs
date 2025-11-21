using UnityEngine;
using UnityEngine.Events;

public class CollectibleScript : MonoBehaviour
{
    public UnityEvent onTriggerEnter;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnTriggerEnter2D(Collider2D collision)
    {
        onTriggerEnter.Invoke();
        Destroy(gameObject);
    }
}
