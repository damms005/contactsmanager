using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_Manager
{
	class vcf_obj
	{

		string cellphonenumber;
		string cellnumer;
		string officephonember;
		string emailinternet;
		string emailhome;
		string name;
		string fax;

		List<string> nameMonitor = new List<string>();


		public void vcf( string vcard_data )
		{
			vcard_data = vcard_data.Replace( "\r\n", "\n" );
			string[] contents = vcard_data.Trim().Split( '\n' );



		}


		/*
		 *
		 * 
		 * 
BEGIN : VCARD
VERSION : 3.0
N : Ibadan;MIS;Unit University of
FN : MIS Unit University of Ibadan
TEL : 
EMAIL : 
END : VCARD
TEL;CELL : 0803 659 4145
TEL;HOME : 0001
TEL;TYPE=CELL : +234 816 741 5559
X-YAHOO;TYPE=HOME : donamecus@yahoo.com
EMAIL;TYPE=INTERNET;TYPE=HOME : info_walters_richfield21@yahoo.co.uk
EMAIL;TYPE=INTERNET : 2958eca90b73c28b@contact.talk.google.com
TEL;TYPE=HOME : +234 816 311 7709
item1.URL : http\
item1.X-ABLabel : PROFILE
TEL;TYPE=WORK : 09093101543
URL : http\
TEL;TYPE=PAGER : 07039211417

		 * 
		 * 
		 */
	}
}
