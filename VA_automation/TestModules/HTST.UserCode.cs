﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////


using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
//using System.Web.Script.Serialization;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace VA_automation.TestModules
{
	public class FacbookHTST
	{
		
		
		public string UserEmail { get; set; }
		
		
		
		public FacbookHTST()
		{
			
		}
	}
	
    public partial class HTST
    {
        
        private void Init()
        {
            
        }

        public void FacbookSecurityValidation(string DOM, string API)
        {
        	//local variables
        	var server="nosniff";
			string keys="";
			string values=""; 
			string url = API;
			
			//Setup API call
			HttpWebRequest httpRequest = (HttpWebRequest)WebRequest.Create(url);
			httpRequest.ContentType = "application/json";
			httpRequest.Method = "POST";
			httpRequest.ContentLength=0;
            
			
			// getting back Headers information
			        HttpWebResponse HttpWebResponse = (HttpWebResponse )httpRequest.GetResponse();
			        for(int i=0; i < HttpWebResponse.Headers.Count; ++i) 
			        {
			     	keys =HttpWebResponse.Headers.Keys[i].ToString();
			     	values =HttpWebResponse.Headers[i].ToString();
			     	
			     	
			     	if (values == server)
			     	   {
			     		
			     		Report.Info("The server appearing as expected");
			     		break;
			     	    }else{
			     		Report.Error("TESTFAILED");
			     	     }
			     	// validation - To makese sure the HTST is availale test:
			          Validate.AreEqual(values,server);
			     		
			        }
			
			
        }

    }
}
