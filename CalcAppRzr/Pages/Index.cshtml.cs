using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalcAppRzr.Pages
{
        public class MyPageModel : PageModel
        {
            [BindProperty]
            public string Text1 { get; set; }

            [BindProperty]
            public string Text2 { get; set; }

            [BindProperty]
            public string Text3 { get; set; }

            public string Output { get; set; }

            public void OnPost()
            {
                // Itt dolgozd fel az input mezõk értékeit, és állítsd be az Output-t
                Output = $"Text 1: {Text1}, Text 2: {Text2}, Text 3: {Text3}";
            }
        }
    }
