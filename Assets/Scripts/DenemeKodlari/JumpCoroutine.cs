using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCoroutine : MonoBehaviour
{

    public bool isJumping;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DoJumpCoroutine());
    }

    IEnumerator DoJumpCoroutine()
    {
        while (true)
        {
            Jump();
            yield return new WaitForSeconds(1);
        }
    }

    void Jump()
    {
        transform.DOMoveY(1,.2f).SetLoops(2,LoopType.Yoyo).OnComplete(SetIsJumpingFalse);
    }

    void SetIsJumpingFalse()
    {
        isJumping = false;
    }
}
