using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScopeAndAccesssModifiers : MonoBehaviour
{
    public int alpha = 5;

    private int beta = 0;
    private int gamma = 5;

    private AnotherClass myOtherClass;
    // Start is called before the first frame update
    void Start()
    {
        alpha = 29;

        myOtherClass = new AnotherClass();
        myOtherClass.FruitMachine(alpha, myOtherClass.apples);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Alpha is set to: " +  alpha);
    }

    void Example(int pens, int crayons)
    {
        int answer;
        answer = pens * crayons * alpha;
        Debug.Log(answer);
    }
}
public class AnotherClass
{
    public int apples;
    public int bananas;

    private int stapeler;
    private int sellotape;
    
    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Fruit Total: " + answer);

    }

    private void OfficeSort(int a, int b)
    {
        int answer;
        answer = a + b; 
        Debug.Log("Office Supliies Total: " + answer);
    }
 }