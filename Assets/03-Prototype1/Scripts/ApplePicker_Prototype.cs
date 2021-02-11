using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ApplePicker_Prototype : MonoBehaviour
{
    [Header ("Set in Inspector")]

    public GameObject bucketPrefab;
    public int numBuckets = 1;
    public float bucketBottomY = -9f;
    public float bucketSpacingY = 1.25f;
    public List<GameObject> bucketList;
        
    // Start is called before the first frame update
    void Start()
    {
        bucketList = new List<GameObject>();
        for (int i=0; i<numBuckets; i++)
       {
           GameObject tBucketGO = Instantiate<GameObject>( bucketPrefab );
           Vector3 pos = Vector3.zero;
           pos.y = bucketBottomY + ( bucketSpacingY * i );
           tBucketGO.transform.position = pos;
           bucketList.Add( tBucketGO );
       } 
    }

    public void AppleDestroyed() {
        GameObject[] tAppleArray=GameObject.FindGameObjectsWithTag("Projectile");
        foreach( GameObject tGO in tAppleArray ) 
        {
            Destroy( tGO );
        }

        int bucketIndex = bucketList.Count-1;
        GameObject tBucketGO = bucketList[bucketIndex];
        bucketList.RemoveAt( bucketIndex );
        Destroy( tBucketGO );

        if ( bucketList.Count == 0 ) {
            SceneManager.LoadScene( "Main-ApplePicker" );
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
