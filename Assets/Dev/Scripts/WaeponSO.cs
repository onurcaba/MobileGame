using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="nameWaepon", menuName ="Create Waepon")]
public class WaeponSO : ScriptableObject
{
    public string waeponType;
    public string waeponTarget;
    public string waeponPower;
}
