using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLogic : MonoBehaviour
{
    public List<Combinaison> _poses;
    public Combinaison CombinaisonActuel;
    public InputsReader InputsReader;
    float countdown = 4;
    float perfectComboCountDown = 1;
    int perfectComboCountUp = 0;
    int succes = 0;
    int miss = 0;

    private void Start()
    {
        
    }

    void Update()
    {
        if(_poses.Count > 0)
        {
            if (countdown > 0)
            {
                int CombinaisonIndex = Random.Range(0, _poses.Count);
                CombinaisonActuel = _poses[CombinaisonIndex];

                countdown -= Time.deltaTime;

                if (InputsReader._rightHand == CombinaisonActuel._rightHand && InputsReader._leftHand == CombinaisonActuel._leftHand && InputsReader._rightLeg == CombinaisonActuel._rightLeg && InputsReader._leftLeg == CombinaisonActuel._leftLeg)
                {
                    if (countdown >= (countdown - perfectComboCountDown))
                    {
                        perfectComboCountDown++;
                        succes++;
                        Debug.Log("Perfect");
                    }
                    else
                    {
                        succes++;
                        Debug.Log("Nice");
                    }
                }
                else
                {
                    miss++;
                    Debug.Log("Miss");
                }
            }
            else
            {
                miss++;
                Debug.Log("Miss");
            }
        }
    }
}
