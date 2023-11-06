using PassKeeperPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassKeeperPages.ManagmentPages
{
    public static class Pages
    {
        static public HomePage? HomePage { get; set; }
        static public SignIn? SignIn { get; set; } = new SignIn();
        static public ForgotPassSendCode? ForgotPassSendCode { get; set; } 
        static public ForgotPassActivateCode? ForgotPassActivateCode { get; set; } 
        static public CreatNewPass? CreatNewPass { get; set; }
        static public Landing1? Landing1 { get; set; }
        static public LandingEdit? LandingEdit { get; set; }
        static public LandingAdd? LandingAdd { get; set; } 
        static public LandingProfile? LandingProfile { get; set; } 
        static public Register? Register { get; set; } 
        static public RegisterPassword? RegisterPassword { get; set; }
        static public SuccsessedEntry? SuccsessedEntry { get; set; } 
    }
}
