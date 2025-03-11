using UnityEngine;

public class TechDemo : MonoBehaviour
{
    [SerializeField] private Material outline;
    [SerializeField] private Material dither;
    public float normalThresh;
    public float colourThresh;
    public float ditherSpread;
    public float colourResolution;
    
    public float normalScale;
    public float colourScale;
    public float spreadScale;
    public float resolutionScale;
    
    
    void Start()
    {
        normalThresh = outline.GetFloat("_Normal_Threshold");
        colourThresh = outline.GetFloat("_Colour_Threshold");
        ditherSpread = dither.GetFloat("_DitherSpread");
        colourResolution = dither.GetFloat("_ColourResolution");
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            normalThresh += normalScale;
            normalThresh = Mathf.Clamp(normalThresh, 0.001f, 10f);
            outline.SetFloat("_Normal_Threshold", normalThresh);
        } else if (Input.GetKey(KeyCode.D))
        {
            normalThresh -= normalScale;
            normalThresh = Mathf.Clamp(normalThresh, 0.001f, 10f);
            outline.SetFloat("_Normal_Threshold", normalThresh);
        } else if (Input.GetKey(KeyCode.W))
        {
            colourThresh += colourScale;
            colourThresh = Mathf.Clamp(colourThresh, 0.1f, 10f);
            outline.SetFloat("_Colour_Threshold", colourThresh);
        } else if (Input.GetKey(KeyCode.S))
        {
            colourThresh -= colourScale;
            colourThresh = Mathf.Clamp(colourThresh, 0.1f, 10f);
            outline.SetFloat("_Colour_Threshold", colourThresh);
        }
    }
}
