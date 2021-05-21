using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public GameObject GO;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal  = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
    private void OnTriggerEnter(Collider other) {
        if  (other.gameObject.CompareTag("Pick Up")){
            Destroy(other.gameObject);

            Instantiate(GO);
            GO.transform.position = new Vector3(Random.Range(-14f, 14f), 0.5f, Random.Range(-14f, 14f));
            
        }
        
    }
}
