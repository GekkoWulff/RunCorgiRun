using UnityEngine;

public class Corgi : MonoBehaviour
{
    
    //access sprite renderer
    private SpriteRenderer corgiSpriteRenderer;

    public void Awake()
    {
        corgiSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void Move(Vector2 direction)
    {
        //facing right direction 
        FaceCorrectDirection(direction);
        
        Vector2 movement = direction * GameParameters.CorgiMoveSpeed * Time.deltaTime;
        corgiSpriteRenderer.transform.Translate(movement);

        corgiSpriteRenderer.transform.position = SpriteTools.ConstrainToScreen(corgiSpriteRenderer);
    }
    
    
    public void FaceCorrectDirection(Vector2 direction)
    {
        //if moving right 
        if (direction.x > 0)
        {
            //unflip corgi
            corgiSpriteRenderer.flipX = false;
        }
        //if moving left
        else if (direction.x < 0)
        {
            //flip corgi 
            corgiSpriteRenderer.flipX = true;
        }
        
        
    }
}
