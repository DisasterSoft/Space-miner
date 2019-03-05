using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class globalUfo : MonoBehaviour
{
    public static string ufo1P, ufo2P, ufo3P, ufo4P, ufo5P, ufo6P;//product
    public static string ufo1D, ufo2D, ufo3D, ufo4D, ufo5D, ufo6D;//db
    public static string ufo1Ar, ufo2Ar, ufo3Ar, ufo4Ar, ufo5Ar, ufo6Ar;//ár
    public static bool ufo1E, ufo2E, ufo3E, ufo4E, ufo5E, ufo6E;//enabled
    public GameObject ufo1PG, ufo2PG, ufo3PG, ufo4PG, ufo5PG, ufo6PG, ufo1DG, ufo2DG, ufo3DG, ufo4DG, ufo5DG, ufo6DG;
    public GameObject ufo1B, ufo2B, ufo3B, ufo4B, ufo5B, ufo6B;
    // Start is called before the first frame update
    //get set produckt
    public static void setUfo1P(string x)

        {
            ufo1P = x;
        }  
    public static string getUfo1P()
        {
            return ufo1P;
        }

    public static void setUfo2P(string x)
    {
        ufo2P = x;
    }
    public static string getUfo2P()
    {
        return ufo2P;
    }
    public static void setUfo3P(string x)
    {
        ufo3P = x;
    }
    public static string getUfo3P()
    {
        return ufo3P;
    }
    public static void setUfo4P(string x)
    {
        ufo4P = x;
    }
    public static string getUfo4P()
    {
        return ufo4P;
    }
    public static void setUfo5P(string x)
    {
        ufo5P = x;
    }
    public static string getUfo5P()
    {
        return ufo5P;
    }

    public static void setUfo6P(string x)
    {
        ufo6P = x;
    }
    public static string getUfo6P()
    {
        return ufo6P;
    }
    //end getter setter for product
    //getter setter for db

    public static void setUfo1D(string x)
    {
        ufo1D = x;
    }
    public static string getUfo1D()
    {
        return ufo1D;
    }

    public static void setUfo2D(string x)
    {
        ufo2D = x;
    }
    public static string getUfo2D()
    {
        return ufo2D;
    }
    public static void setUfo3D(string x)
    {
        ufo3D = x;
    }
    public static string getUfo3D()
    {
        return ufo3D;
    }
    public static void setUfo4D(string x)
    {
        ufo4D = x;
    }
    public static string getUfo4D()
    {
        return ufo4D;
    }
    public static void setUfo5D(string x)
    {
        ufo5D = x;
    }
    public static string getUfo5D()
    {
        return ufo5D;
    }

    public static void setUfo6D(string x)
    {
        ufo6D= x;
    }
    public static string getUfo6D()
    {
        return ufo6D;
    }
    //end getter setter for db
    void Start()
    {
        //setting product
        ufo1PG.GetComponent<Text>().text = "Xuuczeds produce " + ufo1P + "/30 sec";
        ufo2PG.GetComponent<Text>().text = "Ikeods produce " + ufo2P + "/min";
        ufo3PG.GetComponent<Text>().text = "Kacuds produce " + ufo3P + "/5 min";
        ufo4PG.GetComponent<Text>().text = "Crunets produce " + ufo4P + "/10 min";
        ufo5PG.GetComponent<Text>().text = "Cholael produce " + ufo5P + "/30 min";
        ufo6PG.GetComponent<Text>().text = "Lirzet produce " + ufo5P + "/8 hour";
        //settind darab
        ufo1DG.GetComponent<Text>().text = ufo1D;
        ufo2DG.GetComponent<Text>().text = ufo2D;
        ufo3DG.GetComponent<Text>().text = ufo3D;
        ufo4DG.GetComponent<Text>().text = ufo4D;
        ufo5DG.GetComponent<Text>().text = ufo5D;
        ufo6DG.GetComponent<Text>().text = ufo6D;
        //setting Price
        ufo1B.GetComponent<Text>().text = ufo1Ar + " $";
        ufo2B.GetComponent<Text>().text = ufo2Ar + " $";
        ufo3B.GetComponent<Text>().text = ufo3Ar + " $";
        ufo4B.GetComponent<Text>().text = ufo4Ar + " $";
        ufo5B.GetComponent<Text>().text = ufo5Ar + " $";
        ufo6B.GetComponent<Text>().text = ufo6Ar + " $";
    }

    // Update is called once per frame
    void Update()
    {
        //product
        ufo1PG.GetComponent<Text>().text = "Xuuczeds produce " + ufo1P + "/30 sec";
        ufo2PG.GetComponent<Text>().text = "Ikeods produce " + ufo2P + "/min";
        ufo3PG.GetComponent<Text>().text = "Kacuds produce " + ufo3P + "/5 min";
        ufo4PG.GetComponent<Text>().text = "Crunets produce " + ufo4P + "/10 min";
        ufo5PG.GetComponent<Text>().text = "Cholael produce " + ufo5P + "/30 min";
        ufo6PG.GetComponent<Text>().text = "Lirzet produce " + ufo5P + "/8 hour";
        //darab
        ufo1DG.GetComponent<Text>().text = ufo1D;
        ufo2DG.GetComponent<Text>().text = ufo2D;
        ufo3DG.GetComponent<Text>().text = ufo3D;
        ufo4DG.GetComponent<Text>().text = ufo4D;
        ufo5DG.GetComponent<Text>().text = ufo5D;
        ufo6DG.GetComponent<Text>().text = ufo6D;
        //setting Price
        ufo1B.GetComponent<Text>().text =ufo1Ar + " $";
        ufo2B.GetComponent<Text>().text =ufo2Ar + " $";
        ufo3B.GetComponent<Text>().text =ufo3Ar + " $";
        ufo4B.GetComponent<Text>().text =ufo4Ar + " $";
        ufo5B.GetComponent<Text>().text =ufo5Ar + " $";
        ufo6B.GetComponent<Text>().text =ufo6Ar + " $";

    }
}
