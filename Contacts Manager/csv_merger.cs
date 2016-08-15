using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_Manager
{
	class csv_merger
	{

		/*
		 * ***Ensure all names are reasonable
		 * 
		 * get a reference file (usu. first file)
		 * for each record in it,
		 * get a csv_record object
		 * using the csv obj,
		 * get all names into a collection
		 * for each name,
		 * check against the other name in the collection to ensure that it is not a substring of noone and noone is a substring of it
		 * in instance of case of substring, pick the best name to represent the ambiguity by
		 * -only one option: remove the name that begins or ends with a number (this is one is obtainable in csv files I generated from a previously written pyhton code that was suppose to manage contact records)
		 * -make sure the name-checking iteration does not catch the-currently-checked-name in the loop (so 'if' it out)
		 * -report any case of name correction into the output notification box
		 * 
		 * now we have a csv dataset that is devoid of rubbish names
		 * get a csv_file object for this csv dataset
		 * call the 'ensure_clean_dataset' method of that object, so that a name does not appear in more than one record
		 * 
		 * 
		 * *Prevent multiple representation of numbers by more than one name
		*/


		string csv1_string;
		string csv2_string;
		string hybrid_csv_string;

		public csv_merger( string param_csv1_string, string param_csv2_string )
		{
			csv1_string = param_csv1_string;
			csv2_string = param_csv2_string;
		}

		public string do_merge()
		{



			return hybrid_csv_string;
		}
	}
}
