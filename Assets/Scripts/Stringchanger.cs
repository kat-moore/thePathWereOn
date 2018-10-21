using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Stringchanger : MonoBehaviour {
    

    //Color fadeColor = Color.white;
    public Text ourText;
    //public Renderer rend;
    //float ratio;
    // Use this for initialization
    void Start ()
    {
        ourText.text = "- By 2100, if carbon emissions remain unchecked, more than 20 million people's homes could be destroyed because of climate change.";
        ourText.material.SetColor("_Color", Color.white);
        //rend = GetComponent<Renderer>();
        
    }
	
	// Update is called once per frame
	void Update ()
    {
     

    
        //fadeColor = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1));
        bool faded = false;
        int count = 0;
        if (count == 0 && faded == false)
        {
            ourText.text = "- By 2100, if carbon emissions remain unchecked, more than 20 million people's homes could be destroyed because of climate change.";
            
        
            //ratio += Time.deltaTime;
            ourText.color = Color.Lerp(Color.white, Color.clear, Mathf.MoveTowards(Time.time, 10, (float)0.001));
            faded = true;
            count += 1;
            //rend.material.color = opaque;
        }
        if(count == 1)
        {
            ourText.color = Color.Lerp(Color.clear, Color.clear, Mathf.MoveTowards(Time.time, 10, (float)0.001));
        }
        if (count == 1 && faded == true)
        {
            ourText.text = "- These people live mostly in coastal cities like Miami, Florid; Osaka, Japan; and Shanghai, China.";
            ourText.color = Color.Lerp(Color.white, Color.clear, Mathf.MoveTowards(Time.time, 1, (float)0.001));
            faded = false;
            count += 1;
        }/*
        if (count == 2 && faded == true)
        {
            ourText.text = "- These areas would be uninhabitable because they would be underwater, but there are other areas like Southern India that would be uninhabitable due to increasing temperatures.";
            ourText.color = Color.Lerp(Color.white, Color.black, Mathf.MoveTowards(Time.time, 1, (float)0.01));
            count += 1;
        }
        if (count == 3)
        {
            ourText.text = "- By 2100, its predicted that global temperatures could rise up to 10 degrees Fahrenheit.";
            ourText.color = Color.Lerp(Color.white, Color.black, Mathf.MoveTowards(Time.time, 1, (float)0.01));
            count += 1;
        }
        if (count == 4)
        {
            ourText.text = "- By 2100, biodiverse areas like the Amazon Rainforest could lose 50% of their native species. That could mean the extinction of around 40,000 species.";
            ourText.color = Color.Lerp(Color.white, Color.black, Mathf.MoveTowards(Time.time, 1, (float)0.01));
            count += 1;
        }
        if (count == 5)
        {
            ourText.text = "Humanity needs to take Climate Change seriously and begin regulating Carbon Emissions.";
            ourText.color = Color.Lerp(Color.white, Color.black, Mathf.MoveTowards(Time.time, 1, (float)0.01));
            count += 1;
        }


        
        Color fade = ourText.material.color;
        while (fade.a > 0.3)
        {
            //if (ourText.color.a <= 0.3 && count == 0)
            if (count == 0)
            {
                ourText.text = "- These people live mostly in coastal cities like Miami, Florid; Osaka, Japan; and Shanghai, China.";
                //ourText.color = new Color(1, 1, 1, 1);
                //ourText.color = Color.white;
                //rend.material.shader = Shader.Find("_color");
                //rend.material.SetColor("_color", Color.white);
                fade.a -= (float)0.1;
                ourText.CrossFadeColor(fade.a);
                //ourText.GetComponent<Animator>().Play("Bullet1",-1,5);
            }
        }
        ourText.color = Color.white;
        count += 1;
        while (fade.a > 0.3)
        {
            //if (ourText.color.a <= 0.3 && count == 1)
            if(count == 2)
            {
                ourText.text = "- These areas would be uninhabitable because they would be underwater, but there are other areas like Southern India that would be uninhabitable due to increasing temperatures.";
                //ourText.color = new Color(1, 1, 1, 1);
                //count += 1;
                //ourText.GetComponent<Animator>().Play("Bullet1", -1, 5);
                fade.a -= (float)0.1;
            }
        }
        ourText.color = Color.white;
        count += 1;
        
            if (ourText.color.a <= 0.3 && count == 2)
            {
                ourText.text = "- By 2100, its predicted that global temperatures could rise up to 10 degrees Fahrenheit.";
                ourText.color = new Color(1, 1, 1, 1);
                count += 1;
                ourText.GetComponent<Animator>().Play("Bullet1", -1, 5);
            }
            if (ourText.color.a <= 0.3 && count == 3)
            {
                ourText.text = "- By 2100, biodiverse areas like the Amazon Rainforest could lose 50% of their native species. That could mean the extinction of around 40,000 species.";
                ourText.color = new Color(1, 1, 1, 1);
                count += 1;
                ourText.GetComponent<Animator>().Play("Bullet1", -1, 5);
            }
            if (ourText.color.a <= 0.3 && count == 4)
            {
                ourText.text = "Humanity needs to take Climate Change seriously and begin regulating Carbon Emissions.";
                ourText.color = new Color(1, 1, 1, 1);
                count += 1;
                ourText.GetComponent<Animator>().Play("Bullet1", -1, 5);
            }
        }*/

    }
}
