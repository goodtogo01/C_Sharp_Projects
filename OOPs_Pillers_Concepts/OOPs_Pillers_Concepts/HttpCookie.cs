using System;
using System.Collections.Generic;

namespace OOPs_Pillers_Concepts
{
    public class HttpCookie {

        private Dictionary<string, string> _dictionary;
        public string Expiry { get; set; }  


        

        public HttpCookie() {

            _dictionary = new Dictionary<string, string>();

        }

        public string this[string key] {

            get { return _dictionary[key]; }
            set { _dictionary[key] = value;  } 

        }

        public void SetItem(string key, string value) {
      
        
        }

        public string GetItem(string key) {
            return key;

        }
 
    }

}
