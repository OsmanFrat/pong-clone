using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;
    public float boundY = 3.5f;

    public float movementVertical;

    void Update()
    {
        movementVertical = Input.GetAxis("Vertical");

        if((movementVertical > 0 && transform.position.y < boundY || (movementVertical < 0 && transform.position.y > -boundY)))
        {
            transform.position += Vector3.up * movementVertical * speed * Time.deltaTime;
        }
    }
}
