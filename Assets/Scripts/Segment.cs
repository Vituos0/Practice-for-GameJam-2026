using UnityEngine;

public class ColorSegmentData : MonoBehaviour
{
    private EnergyTier tier; // Định nghĩa sẵn: Purple=1, Blue=2...
    private SpriteRenderer spriteRender;

    void Awake() => spriteRender = GetComponent<SpriteRenderer>();

    public void SetSegment(EnergyTier newTier, Color newColor)
    {
        tier = newTier;
        spriteRender.color = newColor;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Segment collided with: " + collision.gameObject.name);
    }

}