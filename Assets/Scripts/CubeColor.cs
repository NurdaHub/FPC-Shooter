using UnityEngine;

public class CubeColor : MonoBehaviour
{
    private Color[] colorsArray = new Color[3];

    private void OnEnable()
    {
        SetColorArray();
        SetRandomColor();
    }

    private void SetColorArray()
    {
        colorsArray[0] = Color.green;
        colorsArray[1] = Color.red;
        colorsArray[2] = Color.yellow;
    }

    private void SetRandomColor()
    {
        var randomIndex = Random.Range(0, 3);
        var randomColor = colorsArray[randomIndex];
        GetComponent<Renderer>().material.color = randomColor;
    }
}
