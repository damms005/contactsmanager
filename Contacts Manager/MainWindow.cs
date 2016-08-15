using System;
using System.IO;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using MetroFramework;
using MetroFramework.Forms;
using System.Windows.Forms;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace Contacts_Manager
{
	public partial class MainWindow : MetroForm
	{

		public Thread vcf_enlister_thread = new Thread( new ThreadStart( () => { } ) );
		public delegate void SetTextCallback( string text );
		public string[] requiredfiles;
		public static bool abort;
		public static List<string> theFiles;
		public Dictionary<string, string> theVCFfields = new Dictionary<string, string>();

		public static string selected_csv_file_to_convert;
		public static string selected_csv1;
		public static string selected_csv2;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void get_vcf_fields_Click( object sender, EventArgs e )
		{
			if( metroTxtbx_cwd.Text.Trim().Length > 1 )
			{
				theVCFfields.Clear();
				vcf_enlister_thread = new Thread( new ThreadStart( vcf_fielder ) );
				vcf_enlister_thread.Name = "Get VCF Fields";
				vcf_enlister_thread.Start();

				return;
			}

			MessageBox.Show( "Select working folder" );
		}

		private void metroButton_selectCWD_Click( object sender, EventArgs e )
		{
			try
			{
				theFiles.Clear();
			}
			catch
			{
				;
			}

			if( folderSelectDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK )
			{
				theFiles = new List<string>( Directory.GetFiles( folderSelectDialog.SelectedPath, "*.vcf", SearchOption.AllDirectories ) );
				metroTxtbx_cwd.Text = folderSelectDialog.SelectedPath;
			}

			metroLabel_status.Text = theFiles.Count + " files";
		}

		public void vcf_fielder()
		{
			string fc;

			setStatusText( "1" + theFiles.Count + " files" );

			foreach( string fileentry in theFiles )
			{
				if( abort )
				{
					abort = false;
					break;
				}

				setStatusText( "1Checking " + fileentry );

				fc = I_O_Class.plainTextReader( fileentry );
				fc = fc.Replace( "\r", "" );//no \r\n
				fc = fc.Replace( "\r\n", "\n" );//double-sure no \r\n
				string[] lines = fc.Split( new string[] { "\n" }, StringSplitOptions.None );

				foreach( string eachLine in lines )
				{
					string[] line_contents = eachLine.Split( ':' );

					if( line_contents.Length < 1 )
					{
						continue;
					}

					string thekey = "";
					string thevalue = "";

					try
					{
						thekey = line_contents[0].Trim();
						thekey = thekey.Trim( new char[] { ';' } );
					}
					catch
					{
						;
					}
					try
					{
						thevalue = line_contents[1].Trim();
						thevalue = thevalue.Trim( new char[] { ';' } );
					}
					catch
					{
						;
					}

					if( thekey.Length < 1 )
					{
						continue;
					}



					try
					{
						if( theVCFfields.ContainsKey( thekey ) )
						{
							if( theVCFfields[thekey].Length < 1 || ( thevalue.Length > theVCFfields[thekey].Length ) )//empty entry for this fields OR //if this is a better example
							{
								theVCFfields[thekey] = thevalue;
							}
						}
						else
						{
							theVCFfields.Add( thekey, thevalue );
						}
					}
					catch
					{
						;
					}
				}
			}


			string ins = "";

			foreach( KeyValuePair<string, string> kv in theVCFfields )
			{
				ins += kv.Key + " : " + kv.Value + "\r\n";
			}

			setOutputVCF_fileds_Appendline( "" );//clear it first
			setOutputVCF_fileds_Appendline( ins );
			setStatusText( "3Completed" );
		}

		public void setStatusText( string Data )
		{
			try
			{
				if( statusStrip1.InvokeRequired )
				{
					SetTextCallback methodcalling = new SetTextCallback( setStatusText );
					statusStrip1.Invoke( methodcalling, new object[] { Data } );
				}
				else
				{
					string destination = Data[0].ToString();
					string theData = Data.Substring( 1 );

					switch( destination )
					{
						case "1":
							{
								toolStripStatusLabel1.Text = theData + "  |  ";
								break;
							}


						case "2":
							{
								toolStripStatusLabel2.Text = theData + "  |  ";
								break;
							}


						case "3":
							{
								toolStripStatusLabel3.Text = theData;
								break;
							}

						default:
							{
								toolStripStatusLabel1.Text = Data;
								break;
							}

					}
				}
			}
			catch
			{
			}
		}

		public void setOutputVCF_fileds_Appendline( string Data )
		{
			try
			{
				if( metroTextBox_vcf_fields.InvokeRequired )
				{
					SetTextCallback methodcalling = new SetTextCallback( setOutputVCF_fileds_Appendline );
					metroTextBox_vcf_fields.Invoke( methodcalling, new object[] { Data } );
				}
				else
				{
					metroTextBox_vcf_fields.AppendText( Data );
				}
			}
			catch
			{
			}
		}

		private void metroButn_select_csv_Click( object sender, EventArgs e )
		{
			if( String.IsNullOrEmpty( selected_csv_file_to_convert ) )
			{
				openFileDialog1.InitialDirectory = new FileInfo( selected_csv_file_to_convert ).DirectoryName;
			}

			if( openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
			{
				selected_csv_file_to_convert = openFileDialog1.FileName;
				metroLabel_selected_csv.Text = selected_csv_file_to_convert;

				string vcf_name = new FileInfo( selected_csv_file_to_convert ).Name + ".vcf";
				int counter = 1;

				while( File.Exists( vcf_name ) )
				{
					vcf_name = new FileInfo( selected_csv_file_to_convert ).Name + counter + ".vcf";
					counter++;
				}

				metroLabel_output_vcf.Text = vcf_name;
			}

		}

		private void metroButton_convert_csv_to__Click( object sender, EventArgs e )
		{

		}

		private void metroButton_csv1_Click( object sender, EventArgs e )
		{
			if( !String.IsNullOrEmpty( selected_csv2 ) )
			{
				openFileDialog1.InitialDirectory = new FileInfo( selected_csv2 ).DirectoryName;
			}
		}

		private void metroButton_select_csv2_Click( object sender, EventArgs e )
		{
			if( !String.IsNullOrEmpty( selected_csv2 ) )
			{
				openFileDialog1.InitialDirectory = new FileInfo( selected_csv2 ).DirectoryName;
			}

			if( openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK )
			{
				selected_csv2 = openFileDialog1.FileName;
				metroLabel_csv2.Text = selected_csv2;

				string hybrid_csv = new FileInfo( selected_csv2 ).Name + ".csv";
				int counter = 1;

				while( File.Exists( hybrid_csv ) )
				{
					hybrid_csv = new FileInfo( hybrid_csv ).Name + counter + ".csv";
					counter++;
				}

				metroTextBox_hybrid_csv_output_name.Text = hybrid_csv;
			}

		}

		private void metroButton_merge_csvs_Click( object sender, EventArgs e )
		{

		}
	}
}
