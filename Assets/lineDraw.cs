using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lineDraw : MonoBehaviour {
    // Start is called before the first frame update
    public LineRenderer lineRenderer;
    public GameObject pivot;
    public GameObject point0;
    public float dist;
    public GameObject tree;
    GameObject newObj;

    void Start() {
        lineRenderer = GetComponent<LineRenderer>();
        point0.transform.position = new Vector3(Random.Range(pivot.transform.position.x-2f, pivot.transform.position.x+2f), Random.Range(pivot.transform.position.y, pivot.transform.position.y+2f), 0);
        
    }

    void Update(){
        lineRenderer.SetPosition(0, pivot.gameObject.transform.position);
        lineRenderer.SetPosition(1, point0.gameObject.transform.position);
        point0.GetComponent<DistanceJoint2D>().distance = dist;
        float pointDist = Vector2.Distance(point0.transform.position, pivot.transform.position);
        if(Input.GetMouseButtonDown(1)){
            newObj = Instantiate(tree);
            // newObj = Instantiate (tree, tree.transform.position, Quaternion.identity);

        }
        // if(Input.GetKeyDown("r")){
        //     Destroy(newObj);
        // }
        // Debug.Log(point0.name + " distance is " + pointDist);
        // point0.GetComponent<HingeJoint2D>().connectedBody = point0.GetComponent<Rigidbody2D>();
    }
}
