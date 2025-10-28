using UnityEngine;

public class BouncySurface : MonoBehaviour
{
    public float bounceStrength;


    //gets called everytime this object collides with something else
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();

        if (ball != null)
        {
            // a vector pointing away from the surface. The direction the ball will bounce off into
            Vector2 normal = collision.GetContact(0).normal;
            ball.AddForce(-normal * this.bounceStrength);
            //negative to add the force in the opposite direction
        }
    }
}
