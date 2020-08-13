using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FileReader
{
    public void ReadFile(string path)
    {

    }

    static public TextAsset ReadFile(AssetBundle bundle, string name)
    {
        return bundle.LoadAsset<TextAsset>(name);
    }

    public static List<string> Favor(string path)
    {
        List<string> inputs = new List<string>();

        StreamReader sr = File.OpenText(path);

        while(true)
        {
            string input = sr.ReadLine();
            if(string.IsNullOrEmpty(input)) { break; }
            inputs.Add(input);
        }

        sr.Close();

        return inputs;
    }
    /*
    public static List<string> Favor2(string path) //호감도 100~299
    {
        List<string> inputs = new List<string>();

        StreamReader sr = File.OpenText(path);

        while (true)
        {
            string input = sr.ReadLine();
            if (string.IsNullOrEmpty(input)) { break; }
            inputs.Add(input);
        }

        sr.Close();

        return inputs;
    }

    public static List<string> Favor3(string path) //호감도 300~499
    {
        List<string> inputs = new List<string>();

        StreamReader sr = File.OpenText(path);

        while (true)
        {
            string input = sr.ReadLine();
            if (string.IsNullOrEmpty(input)) { break; }
            inputs.Add(input);
        }

        sr.Close();

        return inputs;
    }

    public static List<string> Favor4(string path) //호감도 500~699
    {
        List<string> inputs = new List<string>();

        StreamReader sr = File.OpenText(path);

        while (true)
        {
            string input = sr.ReadLine();
            if (string.IsNullOrEmpty(input)) { break; }
            inputs.Add(input);
        }

        sr.Close();

        return inputs;
    }

    public static List<string> Favor5(string path) //호감도 700~899
    {
        List<string> inputs = new List<string>();

        StreamReader sr = File.OpenText(path);

        while (true)
        {
            string input = sr.ReadLine();
            if (string.IsNullOrEmpty(input)) { break; }
            inputs.Add(input);
        }

        sr.Close();

        return inputs;
    }

    public static List<string> Favor6(string path) //호감도 900~1000
    {
        List<string> inputs = new List<string>();

        StreamReader sr = File.OpenText(path);

        while (true)
        {
            string input = sr.ReadLine();
            if (string.IsNullOrEmpty(input)) { break; }
            inputs.Add(input);
        }

        sr.Close();

        return inputs;
    }
    */
}
