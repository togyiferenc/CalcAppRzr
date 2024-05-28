using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class InOut : PageModel
{
    
    public double Input1 { get; set; }

    public double Input2 { get; set; }

    public string Input3 { get; set; } = string.Empty;

    public string Output1 { get; set; } = string.Empty;


    public void OnPost()
    {
        // Itt dolgozd fel az adatokat és állítsd be az output-ot
        Output1 = $"Text 1 + Text 2: {Input1} + {Input1} = {Output1}";
    }
}
