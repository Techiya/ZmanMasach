using System;

public class Mishtamesh
{
    private static readonly long defaultMaxAllowedTime = 3600;

    public String shem { get; set; }
    public String kovetzTmuna { get; set; }
    //private String kovetzKol;
    public String text;
    private long maxAllowedTime = defaultMaxAllowedTime;

    public Mishtamesh()
    {
        
    }

    public Mishtamesh(String _shem, String _kovetztmuna, String _kovetzKol, String _text)
    {
        shem = _shem;
        kovetzTmuna = _kovetztmuna;
        //kovetzKol = _kovetzKol;
        text = _text;
    }

    public Mishtamesh(String stringOfMishtamesh)
    {
        createMishtameshFromString(stringOfMishtamesh);
    }


    public String createString()
    {
        String result = string.Join("#", shem, kovetzTmuna, text);
        return result;
    }

    private void createMishtameshFromString(String mishString)
    {
        string[] parts = mishString.Split('#');
        shem = parts[0];
        kovetzTmuna = parts[1];
        text = parts[2];
    }

}
