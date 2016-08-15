using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contacts_Manager
{
	class csv_file_obj
	{

		Dictionary<string, string> csv_record = new Dictionary<string, string>();

		List<string> recordList;

		public csv_file_obj( List<string> filecontent )
		{
			this.recordList = filecontent;
		}

		/// <summary>
		/// remove duplicate entries, etc
		/// </summary>
		public void cleanup_dataset()
		{

		}

		public void produce_your_data()
		{
			var v = from c in csv_record
					orderby c.Key
					select c.Value;
		}
	}
}
