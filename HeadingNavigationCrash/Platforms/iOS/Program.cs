using ObjCRuntime;
using UIKit;

namespace HeadingNavigationCrash
{
    public class Program
    {
        // This is the main entry point of the application.
        static void Main(string[] args)
        {
            // if you want to use a different Application Delegate class from "AppDelegate"
            // you can specify it here.
            try
            {
                UIApplication.Main(args, null, typeof(AppDelegate));
            }
            catch (Exception ex)
            {
                string msg = $"{ex.Message}";
                string stack = ex.StackTrace;
                
                string nisse = "nils";
            }
            
        }
    }
}
