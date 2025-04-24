using UnityEngine;

public class SceneFog : MonoBehaviour
{
    void Start()
    {
        // Disable fog globally
        RenderSettings.fog = false;

        // Enable fog only for this specific scene (haunted house)
        RenderSettings.fog = true;
        RenderSettings.fogColor = new Color(0.2f, 0.2f, 0.2f);  // A darker fog color
        RenderSettings.fogDensity = 0.1f;  // A very subtle fog density
        RenderSettings.fogMode = FogMode.Exponential;  // Exponential fog
    }
}
