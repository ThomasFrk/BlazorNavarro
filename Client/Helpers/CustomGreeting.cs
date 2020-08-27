using System;
namespace BlazorNavarro.Client.Helpers
{
    public class CustomGreeting
    {
        public static string customGreeting(string value){

            return value.ToUpper() + " hoje é " + DateTime.Today;
        }
    }
}