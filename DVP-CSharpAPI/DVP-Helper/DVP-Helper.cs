using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;


namespace DVP_Helper
{

    public struct playandgetdigits
    {

        public string action
        {
            get
            {
                return "playandgetdigits";
            }
        }

        public string file
        {
            get;
            set;
        }

        public string nexturl
        {
            get;
            set;
        }

        public string app
        {
            get;
            set;
        }

        public string result
        {
            get;
            set;
        }

        public string errorfile
        {
            get;
            set;
        }

        public int digittimeout
        {
            get;
            set;
        }

        public int inputtimeout
        {
            get;
            set;
        }

        public int loop
        {
            get;
            set;
        }

        public string terminator
        {
            get;
            set;
        }


        public string strip
        {
            get;
            set;
        }

        public int digits
        {
            get;
            set;
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


   // callData["result"], callData["errorfile"], callData["digittimeout"], callData["inputtimeout"], callData["loops"], callData["terminator"], callData["strip"], callData["digits"], maxdigits));


    public struct play
    {
        public string action
        {
            get
            {
                return "play";
            }
        }

        public string file
        {
            get;
            set;
        }

        public string nexturl
        {
            get;
            set;
        }

        public string app
        {
            get;
            set;
        }

        public string result
        {
            get;
            set;
        }

        public string errorfile
        {
            get;
            set;
        }

        public int digittimeout
        {
            get;
            set;
        }

        public int inputtimeout
        {
            get;
            set;
        }

        public int loop
        {
            get;
            set;
        }

        public string terminator
        {
            get;
            set;
        }


        public string strip
        {
            get;
            set;
        }

        public int digits
        {
            get;
            set;
        }
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }


    }


    public struct record
    {

        public string action
        {
            get
            {
                return "record";
            }
        }

        public string file
        {
            get;
            set;
        }

        public string nexturl
        {
            get;
            set;
        }

        public string app
        {
            get;
            set;
        }

         public string posturl
        {
            get;
            set;
        }


        public string result
        {
            get;
            set;
        }

        public string errorfile
        {
            get;
            set;
        }

        public int digittimeout
        {
            get;
            set;
        }

        public int inputtimeout
        {
            get;
            set;
        }

        public int limit
        {
            get;
            set;
        }

        public string terminator
        {
            get;
            set;
        }


        public string strip
        {
            get;
            set;
        }

        public int digits
        {
            get;
            set;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

   


    public struct pause
    {

        public string action
        {
            get
            {
                return "pause";
            }
        }

        public string file
        {
            get;
            set;
        }

        public string nexturl
        {
            get;
            set;
        }


        public string app
        {
            get;
            set;
        }


        public string result
        {
            get;
            set;
        }

        public string errorfile
        {
            get;
            set;
        }

        public int digittimeout
        {
            get;
            set;
        }

        public int inputtimeout
        {
            get;
            set;
        }

        public int milliseconds
        {
            get;
            set;
        }

        public string terminator
        {
            get;
            set;
        }


        public string strip
        {
            get;
            set;
        }

        public int digits
        {
            get;
            set;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }


   
    public struct speak
    {
        public string action
        {
            get
            {
                return "speak";
            }
        }

        public string file
        {
            get;
            set;
        }

        public string engine
        {
            get;
            set;
        }

        public string voice
        {
            get;
            set;
        }


        public string nexturl
        {
            get;
            set;
        }

        public string app
        {
            get;
            set;
        }

        public string result
        {
            get;
            set;
        }

        public string errorfile
        {
            get;
            set;
        }

        public int digittimeout
        {
            get;
            set;
        }

        public int inputtimeout
        {
            get;
            set;
        }

        public int milliseconds
        {
            get;
            set;
        }

        public string terminator
        {
            get;
            set;
        }


        public string strip
        {
            get;
            set;
        }

        public int digits
        {
            get;
            set;
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }

/*
     public struct pause
    {
        public string file
        {
            get;
            set;
        }

        public string nexturl
        {
            get;
            set;
        }


        public string result
        {
            get;
            set;
        }

        public string errorfile
        {
            get;
            set;
        }

        public int digittimeout
        {
            get;
            set;
        }

        public int inputtimeout
        {
            get;
            set;
        }

        public int milliseconds
        {
            get;
            set;
        }

        public string terminator
        {
            get;
            set;
        }


        public string strip
        {
            get;
            set;
        }

        public int digits
        {
            get;
            set;
        }
    }*/

     //res.write(messageGenerator.Say(callData["file"], mainServer, mainServer, callData["result"], callData["errorfile"], callData["digittimeout"], callData["inputtimeout"], callData["loops"], callData["language"], callData["type"], callData["method"], callData["gender"], callData["terminator"], callData["strip"], callData["digits"], maxdigits));


     public struct say
     {

         public string action
         {
             get
             {
                 return "say";
             }
         }

         public string file
         {
             get;
             set;
         }

         public string language
         {
             get;
             set;
         }

         public string type 
         {
             get;
             set;
         }

         public string method
         {
             get;
             set;
         }

         public string gender
         {
             get;
             set;
         }

         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }

         public string errorfile
         {
             get;
             set;
         }

         public int digittimeout
         {
             get;
             set;
         }

         public int inputtimeout
         {
             get;
             set;
         }

         public int loops
         {
             get;
             set;
         }

         public string terminator
         {
             get;
             set;
         }


         public string strip
         {
             get;
             set;
         }

         public int digits
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }
     }



     public struct setdtmf
     {
         public string action
         {
             get
             {
                 return "setdtmf";
             }
         }


         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }

         public string result
         {
             get;
             set;
         }

         public string dtmftype
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }

     }

     public struct execute
     {
         public string action
         {
             get
             {
                 return "execute";
             }
         }


         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }

         public string application
         {
             get;
             set;
         }

         public string data
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }

    //res.write(messageGenerator.Dial(mainServer, mainServer, callData["context"], callData["dialplan"], callData["callername"], callData["callernumber"], callData["number"]));



     public struct dial
     {

         public string action
         {
             get
             {
                 return "dial";
             }
         }

         public string nexturl
         {
             get;
             set;
         }


         public string app
         {
             get;
             set;
         }

         public string result
         {
             get;
             set;
         }

         public string context
         {
             get;
             set;
         }

         public string dialplan
         {
             get;
             set;
         }

         public string callername
         {
             get;
             set;
         }

         public string callernumber
         {
             get;
             set;
         }

         public string number
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }



     public struct recordcall
     {
         public string action
         {
             get
             {
                 return "recordcall";
             }
         }

         public string nexturl
         {
             get;
             set;
         }


         public string app
         {
             get;
             set;
         }

         public string result
         {
             get;
             set;
         }

         public int limit
         {
             get;
             set;
         }

         public string name
         {
             get;
             set;
         }


         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }
     //res.write(messageGenerator.RecordCall(mainServer, mainServer, callData["limit"], callData["name"]));


     public struct conference
     {
         public string action
         {
             get
             {
                 return "conference";
             }
         }


         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }


         public string data
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }


     public struct @break
     {
         public string action
         {
             get
             {
                 return "break";
             }
         }

         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }

         public string cause
         {
             get;
             set;
         }


         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }

     }




     public struct queue
     {

         public string action
         {
             get
             {
                 return "queue";
             }
         }

         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }

         public string skill
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }

     // res.write(messageGenerator.VoiceMail(mainServer, mainServer, callData["check"], callData["authonly"], profile, domain, callData["id"]));

     public struct voicemail
     {
         public string action
         {
             get
             {
                 return "voicemail";
             }
         }

         public string nexturl
         {
             get;
             set;
         }
         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }

         public string check
         {
             get;
             set;
         }

         public string id
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }



     public struct hangup
     {

         public string action
         {
             get
             {
                 return "hangup";
             }
         }

         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }


         public string result
         {
             get;
             set;
         }

         public string cause
         {
             get;
             set;
         }
        
         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }



     }


     public struct @continue
     {
         public string action
         {
             get
             {
                 return "continue";
             }
         }

         public string nexturl
         {
             get;
             set;
         }

         public string app
         {
             get;
             set;
         }



         public string result
         {
             get;
             set;
         }

         public override string ToString()
         {
             return JsonConvert.SerializeObject(this);
         }


     }


     // var body = { session: queryData["session_id"], direction: queryData["Caller-Direction"], ani: queryData["Caller-Caller-ID-Number"], dnis: queryData["Caller-Destination-Number"], name: queryData["Caller-Caller-ID-Name"], result: resultValue };

     public struct CallData
     {
         public string session
         {
             get;
             set;
         }

         public string direction
         {
             get;
             set;
         }

         public string ani
         {
             get;
             set;
         }

         public string dnis
         {

             get;
             set;
         }

         public string name
         {
             get;
             set;

         }

         public string result
         {
             get;
             set;
         }
     }


     public class BrowserJsonFormatter : JsonMediaTypeFormatter
     {
         public BrowserJsonFormatter()
         {
             this.SupportedMediaTypes.Add(new MediaTypeHeaderValue("application/json"));
             this.SerializerSettings.Formatting = Formatting.Indented;
         }

         public override void SetDefaultContentHeaders(Type type, HttpContentHeaders headers, MediaTypeHeaderValue mediaType)
         {
             base.SetDefaultContentHeaders(type, headers, mediaType);
             headers.ContentType = new MediaTypeHeaderValue("application/json");
         }
     }

}
