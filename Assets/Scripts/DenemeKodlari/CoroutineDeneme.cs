using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineDeneme : MonoBehaviour
{

    public float beklemeSuresi;

    public GameObject kurePrefab;

    private Coroutine _kureOlusturmaCoroutine;

    public List<Coroutine> coroutines = new List<Coroutine>();
    
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.J))
        {
            _kureOlusturmaCoroutine=StartCoroutine(KureOlusturucuCoroutine(coroutines.Count));
            coroutines.Add(_kureOlusturmaCoroutine);
            print(coroutines.Count);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            foreach(Coroutine coroutine in coroutines)
            {
                StopCoroutine(coroutine);
            }
        }

    }
    IEnumerator KureOlusturucuCoroutine(float x) 
    {
        while (true)
        {
            var yeniKure= Instantiate(kurePrefab);
            yeniKure.transform.position = new Vector3(x,0,0);

            yeniKure.transform.localScale = Vector3.zero;
            yeniKure.transform.DOScale(1, .2f).SetEase(Ease.OutBack);

            yeniKure.transform.DOMoveY(5, 1).SetDelay(.2f);
            yeniKure.transform.DOScale(0, .2f).SetEase(Ease.InBack).SetDelay(1.2f);

            Destroy(yeniKure.gameObject,1.4f);
            yield return new WaitForSeconds(beklemeSuresi);
        }
    }
}
