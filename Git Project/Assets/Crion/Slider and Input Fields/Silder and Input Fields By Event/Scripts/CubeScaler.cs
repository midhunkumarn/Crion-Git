using UnityEngine;

public class CubeScaler : MonoBehaviour
{
    
    private Transform cube;

    void Start()
    {
        cube = GameObject.Find("Cube").transform;
    }
    public void ChangeCubeSize(float size)
    {

        cube.localScale = new Vector3(size, size, size);
    }
}