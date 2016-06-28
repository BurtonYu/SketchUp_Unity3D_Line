using UnityEngine;
using System.Collections;
using UnityEngine.Rendering;
using Assets;

public class Demo : MonoBehaviour
{
    private LineRenderer line;
    public Color c = Color.yellow;
    public float wid = 0.05F;
    private Vector3[] vec1;
    private Vector3[] vec2;
    private Vector3[] points; 
    private ReadXml r=new ReadXml();
    int i;
    public GameObject prefab;
    private GameObject copy;

  
    //public int lengthOfLineRenderer = 20;
    void Start()
    {
        points = new Vector3[2];
        r.gitv();
        vec1 = r.v1;
        vec2 = r.v2;

        for (i = 0; i < vec1.Length; i++)
        {
            points[0] = vec1[i];
            points[1] = vec2[i];
            //copy=Instantiate(prefab);
            copy = Instantiate(prefab, transform.position, transform.rotation) as GameObject;
            copy.transform.parent = transform;
            line = copy.GetComponent<LineRenderer>();
            //line.material = new Material(Shader.Find("Particles/Multiply"));
            //line.material = new Material(Shader.Find("Custom/test"));
            line.material = new Material(Shader.Find("Custom/NewSurfaceShader"));
            line.useLightProbes = false;
            line.receiveShadows = false;
            line.shadowCastingMode = ShadowCastingMode.Off;
            line.SetColors(c, c);
            line.SetWidth(wid, wid);

            line.SetPositions(points);

        }
    }

    void Update() {   
    }

}
