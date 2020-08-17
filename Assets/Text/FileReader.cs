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
}
