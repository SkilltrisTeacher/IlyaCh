using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Portal : MonoBehaviour
{
    [SerializeField] private LayerMask playerLayer ;
    [SerializeField] private string nextLevelName;
    [SerializeField] private Collider2D portalCollider;
    
    private void Update()
    {
        if(portalCollider.IsTouchingLayers(playerLayer))
        {
            SceneManager.LoadScene(nextLevelName);
        }
    }
}
