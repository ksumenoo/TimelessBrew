using UnityEngine;

public class WaterUp : MonoBehaviour

{
    public float growthAmount = 0.002f;
    public float maxY = 2f;
    void OnParticleCollision(GameObject other)
    {
        Vector3 scale = transform.localScale;
        if (scale.y < maxY)
        {
            scale.y += growthAmount;
            transform.localScale = scale;
        }
    }



    
}


