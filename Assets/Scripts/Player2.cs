using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float speed = 10f;
    public float boundY = 3.7f;

    public float movementVertical;

    void Update()
    {
        movementVertical = Input.GetAxis("Vertical2");

        if((movementVertical > 0 && transform.position.y < boundY || (movementVertical < 0 && transform.position.y > -boundY)))
        {
            transform.position += Vector3.up * movementVertical * speed * Time.deltaTime;
        }
    }
}
