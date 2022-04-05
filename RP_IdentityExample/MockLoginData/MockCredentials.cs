using RP_IdentityExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RP_IdentityExample.MockLoginData
{
    public class MockCredentials
    {       
            private static List<Credential> credentials = new List<Credential>() {
                new Credential("lara@zealand.dk", "lara"),
                new  Credential( "david@zealand.dk", "david"),
                new Credential( "lars@zealand.dk","lars"),
                new Credential( "kasper@zealand.dk","kasper")
            };
            public static bool CheckCredentails( string name , string pass)
            {
                return credentials.Exists(n=>n.Username==name  && n.Password==pass);
            }     
        public static  void  NewCredential(Credential credential)
        {
            credentials.Add(credential);
        }
    }
}
